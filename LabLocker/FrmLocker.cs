using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace LabLocker
{
    public partial class FrmLocker : Form
    {
        SqlDataAdapter appDA;
        //Point stxy;

        public FrmLocker()
        {
            InitializeComponent();
            this.lbOwner.Tag = "";
            this.lbLogin.Tag = "";
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //DateTime dat = this.dateTimePicker1.Value;
            //string dat = DateTime.Now.ToShortDateString();
            LoadList(DateTime.Now);
        }





        private void Testing_Load(object sender, EventArgs e)
        {
            //get the ip address from connection string
            tolStripBar2.Text = DBAccess.connStr.Split(';')[0];

            //record the start position
            //stxy = this.Location;

            LockWnd();
            if (DBAccess.CheckConnStatus())
            {
                LoadList(DateTime.Now);
                this.timeList.Enabled = true;
            }
            else
            {
                SetInforBar("Can't connect to Database.");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLocker_MouseLeave(object sender, EventArgs e)
        {

        }

        //control time
        //int listInx = 100;

        //bool ListFreshed = false;
        void RefreshListOnDayChanged()
        {
            //this.timer1.Stop();
            Debug.WriteLine("starting:-------" + DateTime.Now.ToLongTimeString());
            LoadList(DateTime.Now);
            Debug.WriteLine("end:--------" + DateTime.Now.ToLongTimeString());
            //this.timer1.Start();
        }

        //Init the apppointment2 table
        void InitAppointTab(DateTime dat2)
        {
            string device = lbMachine.Tag.ToString();
            string dat = dat2.ToShortDateString();
            //Initialize the appointment2
            InitlogOps iniOps = new InitlogOps(dat);
            bool flag = iniOps.IsFilled(dat);

            if (!flag)
            {
                iniOps.SetFilledFlag(dat, true);
                AppointOps appointOps = new AppointOps();
                appointOps.InitAppointTable(device, dat);
            }
        }

        //list start posion
        int CurrentInx = 0;
        int listInx = 0;
        bool HaveSetupNextDay = false;
        bool ChangeFactor = false;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Get the current time order#
            listInx = this.ReturnCurrentOrder(DateTime.Now);


            //next day, listInx = 0; then refresh list
            //CurrentInx should reset to 0 as well
            //Only setup onetime
            if (listInx == 0 && HaveSetupNextDay == false)
            {
                //ini table
                //InitAppointTab(DateTime.Now.AddDays(1));
                LoadList(DateTime.Now);

                //To avoid setup again
                HaveSetupNextDay = true;

                //Set the currentix != listInx for next logic
                CurrentInx = 1;
            }

            //Reset SetupNextFlag; when listInx moved > 0
            //Then system will init date in next day
            if (listInx > 0 && HaveSetupNextDay == true)
            {
                HaveSetupNextDay = false;
            }

            //ListInx will change by real time;
            //Move CurrentInx to next; set CurrentInx=ListInx
            if (listInx != CurrentInx && havingItem(listInx))
            {
                //stop timer, check list and lockwnd
                timeList.Stop();

                //Change the color; moved
                listView1.Items[CurrentInx].BackColor = Color.White;
                listView1.Items[listInx].BackColor = Color.LightBlue;
                this.listView1.Items[listInx].EnsureVisible();

                //Set same, to avoid move everytime
                CurrentInx = listInx;

                //Set the information
                SetTagAndText(listInx);

                //Excute the lock procedure
                if (GetLockSignal())
                {
                    LockWnd();
                    SetInforBar("Locked, please login for current owner#" + this.lbOwner.Tag.ToString());
                }
                else
                {
                    SetInforBar("You can login to unlock for user#" + this.lbLogin.Tag);
                }

                //show inforbar
                this.tolStripBar5.Text = DateTime.Now.ToLongTimeString() + "Moving# " + CurrentInx.ToString() + " -> " + listInx.ToString();

                //next round
                timeList.Start();
            }
            else
            {
                //show inforbar
                if (ChangeFactor)
                {
                    ChangeFactor = false;
                    this.tolStripBar5.Text = DateTime.Now.ToLongTimeString() + " Held# Current Indexx:" + CurrentInx.ToString() + " : Next Index:" + (listInx + 1).ToString();
                }
                else
                {
                    ChangeFactor = true;
                    this.tolStripBar5.Text = DateTime.Now.ToLongTimeString();
                }

            }


        }


        //Force exit
        bool ForceQuit = false;
        private void FrmLocker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ForceQuit)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                }
            }

        }

        private void BtnUnlock_Click(object sender, EventArgs e)
        {
            if (this.txtUsername.Text.Trim() != "")
            {
                UnlockAction();
            }

        }

        private void NfiLocker_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LockWnd();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedIndices.Count != 0)
            {
                //ListViewItem itm = this.listView1.Items[0];
                //Debug.WriteLine(itm.SubItems[1].Text+"---"+itm.SubItems[2].Text);
                //Debug.WriteLine(DateTime.Now.ToLongTimeString() + "----login user---:" + this.lbLogin.Tag  + "---lock status:---" + this.lbStatus.Tag);
            }

        }

        #region
        //rfresh datepicker


        //Load list
        void LoadList(DateTime dat)
        {
            if (DBAccess.CheckConnStatus())
            {
                DataSet ds = new DataSet();
                //DateTime dat = this.dateTimePicker1.Value;

                AppointOps apOps = new AppointOps();
                appDA = apOps.GetAppointDA(dat.ToShortDateString());
                appDA.Fill(ds, "appointment2");

                DataTable tab = ds.Tables[0];
                int i = 0;

                //list start position
                CurrentInx = 0;

                this.listView1.Items.Clear();

                foreach (DataRow row in tab.Rows)
                {
                    this.listView1.Items.Add(row["order"].ToString());
                    this.listView1.Items[i].SubItems.Add(row["device"].ToString());
                    this.listView1.Items[i].SubItems.Add(row["bookdate"].ToString());
                    this.listView1.Items[i].SubItems.Add(row["bookhour"].ToString());
                    this.listView1.Items[i].SubItems.Add(row["bookminutes"].ToString());
                    this.listView1.Items[i].SubItems.Add(row["username"].ToString());
                    this.listView1.Items[i].SubItems.Add(row["id"].ToString());

                    i = i + 1;
                }

                this.lbRows.Text = tab.Rows.Count.ToString();
            }
        }

        //Movenext listitem
        //move list item
        bool havingItem(int listInx)
        {
            //select next list item
            if (this.listView1.Items.Count != 0 && listView1.Items.Count >= listInx)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void SetTagAndText(int listInx)
        {
            //Get the listitem and set the lable tag and text
            this.lbOrder.Text = "Order#" + this.listView1.Items[listInx].Text;
            this.lbOrder.Tag = this.listView1.Items[listInx].Text;

            this.lbOwner.Text = "Owner#" + this.listView1.Items[listInx].SubItems[5].Text;
            this.lbOwner.Tag = this.listView1.Items[listInx].SubItems[5].Text;

            this.lbTime.Text = "Time#" + listView1.Items[listInx].SubItems[4].Text;



        }

        //Check lock status
        bool GetLockSignal()
        {
            bool lockStatus;

            //Different user lock
            if (this.lbOwner.Tag.ToString() == this.lbLogin.Tag.ToString() && lbOwner.Tag.ToString() != "")
            {
                lockStatus = false;
                this.lbStatus.Text = "Lock Status#" + "false";
                this.lbStatus.Tag = lockStatus;
            }
            else
            {
                lockStatus = true;
                this.lbStatus.Text = "Lock Status#" + "true";
                this.lbStatus.Tag = lockStatus;
            }

            return lockStatus;
        }

        void FreezWnd()
        {
            //int WM_SYSCOMMNAD = 0x112;
            //int SC_MOVE = 0xF012;


        }

        void LockWnd()
        {
            //Taskbar
            int TaskBarHwnd;
            TaskBarHwnd = LockWinOps.FindWindow("Shell_traywnd", "");
            int ProgramWindow;
            ProgramWindow = LockWinOps.FindWindow("progman", "");


            //Lock
            //Hide taskbar
            LockWinOps.SetWindowPos(TaskBarHwnd, 0, 0, 0, 0, 0, LockWinOps.SWP_HIDEWINDOW);
            LockWinOps.SetWindowPos(ProgramWindow, 0, 0, 0, 0, 0, LockWinOps.SWP_HIDEWINDOW);

            //Max window

            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;

            //Show the locker
            this.Show();

        }

        void UnlockWnd()
        {


            //Taskbar
            int TaskBarHwnd;
            TaskBarHwnd = LockWinOps.FindWindow("Shell_traywnd", "");
            int ProgramWindow;
            ProgramWindow = LockWinOps.FindWindow("progman", "");
            //Unlock
            //Show taskbar
            LockWinOps.SetWindowPos(TaskBarHwnd, 0, 0, 0, 0, 0, LockWinOps.SWP_SHOWWINDOW);
            LockWinOps.SetWindowPos(ProgramWindow, 0, 0, 0, 0, 0, LockWinOps.SWP_SHOWWINDOW);

            //Hide the locker
            this.Hide();
        }

        //login
        bool Login(string username, string password)
        {
            bool havingUser = UserOps.ExistingUsr(username, password);
            SetTextAndBarAfterLogin(havingUser, username);
            return havingUser;
        }

        void SetTextAndBarAfterLogin(bool status, string username)
        {
            if (status)
            {
                this.lbLogin.Text = "Login user#" + username;
                this.lbLogin.Tag = username;
                SetInforBar("Login successfully for user#" + username);
            }
            else
            {
                SetInforBar("Wrong username and password, please try again.");
            }
        }

        //Loop the list by timer
        int ReturnCurrentOrder(DateTime dat)
        {
            //In every 10 mintues
            int[] minlist = new int[] { 0, 10, 20, 30, 40, 50 };
            int myhour = dat.Hour;
            int mymin = dat.Minute;

            //start position hour*int
            int location = myhour * minlist.Length;

            //get the offsets
            int minoffset = 0;
            for (int i = 0; i < minlist.Length; i++)
            {
                //current minutes >= minlist, then offset=minlist location, utill minutes < minlist
                //e.g. minutes 15, 15>=0, offset++; then 15>=10, offset++; 15<20, break;
                if (mymin >= minlist[i])
                {
                    minoffset = i;
                }
                else //minutes < minlist location; e.g. 15<20, exit
                {
                    break;
                }
            }

            return location + minoffset;
        }

        //Force quit
        void ToForceQuit()
        {
            //Force quit
            this.nfiLocker.Dispose();
            ForceQuit = true;
            UnlockWnd();
            this.Close();
        }

        //Setup informatioin bar
        void SetInforBar(string text)
        {
            this.lbInfo.Text = text;
        }

        //unlock action
        void UnlockAction()
        {
            string username = this.txtUsername.Text.Trim().ToLower();
            string password = this.txtPassword.Text;

            if (username == "admin" && password == getAdminPwd())
            {
                ToForceQuit();
            }
            else
            {
                if (DBAccess.CheckConnStatus())
                {
                    //Login
                    bool loginSuccess = this.Login(username, password);

                    if (loginSuccess)
                    {
                        if (username.ToLower() == lbOwner.Tag.ToString())
                        {
                            UnlockWnd();
                            SetInforBar("Unlocked for user#" + username);
                        }
                        else
                        {
                            SetInforBar("You are not current owner, can't unlock!");
                        }
                    }
                }
                else
                {
                    SetInforBar("Can't connect to Database");
                }

            }

            this.txtUsername.ResetText();
            this.txtPassword.ResetText();
        }

        //change admin password here
        string getAdminPwd()
        {
            return "88888888";
            //return "5632596879"; //change on 2023-9-1; upload to Azure on 23/11/3
        }



        #endregion

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UnlockAction();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadList(DateTime.Now);

        }

        private void FrmLocker_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void FrmLocker_Move(object sender, EventArgs e)
        {
            //this.Location = stxy;
            LockWnd();
        }

        //Freeze wnd
        int WM_SYSCOMMNAD = 0x112;
        int SC_MOVE = 0xF012;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMNAD)
            {
                if ((int)m.WParam == SC_MOVE)
                {
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void timeControl_Tick(object sender, EventArgs e)
        {
            //split the connection str, then get the ip address
            string svr = tolStripBar2.Text;
            svr = svr.Split('=')[1];
            svr = svr.Split('\\')[0];

            Ping ping = new Ping();
            PingReply pr = ping.Send(svr);
            tolStripBar4.Text = svr + "#" + pr.Status.ToString();
        }

        private void FrmLocker_RegionChanged(object sender, EventArgs e)
        {

        }

        private void FrmLocker_Activated(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void tolStripBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
