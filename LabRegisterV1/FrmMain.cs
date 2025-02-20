using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LabRegisterV1
{
    public partial class FrmMain : Form
    {
        SqlDataAdapter appDa;
        DataSet appDS;

        AppointOps appointOps = new AppointOps();

        //timerOrderOffset 1 = 10 mins
        const int timeOrderOffset = 11;

        public FrmMain()
        {
            InitializeComponent();

            this.datPicker.MinDate = DateTime.Now;
            this.datPicker.MaxDate = DateTime.Now.AddDays(1);
            this.datPicker.Value = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //init
            this.coboxDevice.SelectedIndex = 0;
            //this.InitAppointTab();
        }



        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //ini table
            InitAppointTab();
            //Reload data to listview
            FreshTheList();
            //Get minutes
            SetBookedMinutesFromDS();
            //Refersh the user time profile
            RefreshUserTimeProfile();

            //show text
            SetTbarText();
        }





        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (isLoaded)
            {
                string hour = this.treHour.SelectedNode.Text;
                DataRow[] rows = appDS.Tables["appointment2"].Select("bookhour='" + hour + "'");
                FillToListview(rows, ref this.listVappoint);
            }

        }





        private void BtnSetUsr_Click(object sender, EventArgs e)
        {
            List<int> planTimeSlotsA = new List<int>();
            List<int> planTimeSlotsB = new List<int>();
            List<int> planTimeIndxA = new List<int>();
            List<int> planTimeIndxB = new List<int>();


            foreach (int id in this.listVappoint.CheckedIndices)
            {
                if (listVappoint.Items[id].SubItems[5].Text == DBAccess.nullname)
                {
                    int cid = Convert.ToInt32(this.listVappoint.Items[id].SubItems[7].Text);
                    int order = Convert.ToInt32(this.listVappoint.Items[id].Text);

                    //get current time order
                    int timeOrder = this.ReturnTimeOrder(DateTime.Now);


                    if (order >= 48 && order <= 137)
                    {
                        planTimeSlotsA.Add(cid);
                        planTimeIndxA.Add(id);
                    }
                    else
                    {
                        planTimeSlotsB.Add(cid);
                        planTimeIndxB.Add(id);
                    }
                }
            }

            //Get the already booked time slots
            SetBookedMinutesFromDS();
            if (bookedMinA + planTimeSlotsA.Count() > totalMinA / 10)
            {
                MessageBox.Show("You can only book " + totalMinA.ToString() + " minutes (8:00-23:00)");
                uncheckListByIDs(planTimeIndxA.ToArray());
            }
            else
            {
                updateDSByCID(planTimeSlotsA.ToArray());
                updateListByIDs(planTimeIndxA.ToArray());
                uncheckListByIDs(planTimeIndxA.ToArray());
            }

            if (bookedMinB + planTimeSlotsB.Count() > totalMinB / 10)
            {
                MessageBox.Show("You can only book " + totalMinB.ToString() + " minutes (23:00-8:00)");
                uncheckListByIDs(planTimeIndxB.ToArray());
            }
            else
            {
                updateDSByCID(planTimeSlotsB.ToArray());
                updateListByIDs(planTimeIndxB.ToArray());
                uncheckListByIDs(planTimeIndxB.ToArray());
            }

            appDa.Update(appDS, "appointment2");

            //Change the text
            SetBookedMinutesFromDS();
            SetTbarText();
        }

        private void BtnUnbook_Click(object sender, EventArgs e)
        {
            foreach (int id in this.listVappoint.CheckedIndices)
            {
                if (listVappoint.Items[id].SubItems[5].Text == DBAccess.currentuseranme)
                {
                    this.listVappoint.Items[id].SubItems[5].Text = DBAccess.nullname;
                    string cid = this.listVappoint.Items[id].SubItems[7].Text;
                    appDS.Tables["appointment2"].Select("id=" + cid)[0]["username"] = DBAccess.nullname;
                    Console.WriteLine(id);
                    this.listVappoint.Items[id].Checked = false;
                }
            }
            appDa.Update(appDS, "appointment2");


            //Change the text
            SetBookedMinutesFromDS();
            SetTbarText();
        }

        private void ListVappoint_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int i = this.listVappoint.CheckedItems.Count;
            int timeOrder = ReturnTimeOrder(DateTime.Now);


            if (i != 0)
            {
                foreach (ListViewItem itm in listVappoint.CheckedItems)
                {
                    //To avoid check others item
                    string username = itm.SubItems[5].Text;
                    if (username != DBAccess.currentuseranme && username != DBAccess.nullname)
                    {
                        //Console.WriteLine("uncheck");
                        itm.Checked = false;
                    }

                    //To avoid select old items for today
                    //timeOrder is current timeslot
                    //timeOrderOffset is the offset 1 = 10mins; + move next, - move up
                    int toChangeOrder = Convert.ToInt32(itm.Text);
                    string dat = itm.SubItems[2].Text;
                    if (toChangeOrder <= timeOrder + timeOrderOffset && dat == DateTime.Now.ToShortDateString())
                    {
                        itm.Checked = false;
                    }
                }

            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (DBAccess.currentuseranme == DBAccess.nullname)
            {
                //login
                FrmVerifyUser vfm = new FrmVerifyUser();
                vfm.TopMost = true;
                vfm.ShowDialog();
                if (DBAccess.currentuseranme != DBAccess.nullname)
                {
                    this.btnSetUsr.Enabled = true;
                    this.btnUnbook.Enabled = true;
                    this.btnSubmit.Enabled = true;
                    this.treHour.Enabled = true;
                    this.listVappoint.Enabled = true;
                    this.lbUsr.Text = "Current user#" + DBAccess.currentuseranme;

                    //Reload the current users profile
                    //ini table; read to DataSet; including user profile
                    //InitAppointTab();
                    //Reload data to listview
                    //FreshTheList();
                    //Get minutes
                    //SetBookedMinutesFromDS();
                    //Refersh the user time profile
                    //RefreshUserTimeProfile();

                    //show text
                    //SetTbarText();
                }

            }
            else
            {
                //logout
                DBAccess.currentuseranme = DBAccess.nullname;
                this.btnSetUsr.Enabled = false;
                this.btnUnbook.Enabled = false;
                this.btnSubmit.Enabled = false;
                this.treHour.Enabled = false;
                this.listVappoint.Enabled = false;
                this.listVappoint.SelectedIndices.Clear();
                this.lbUsr.Text = "Current user#" + DBAccess.nullname;
                ClearMinutes();
                //SetTbarText();
            }

            SetTbarText();
            SetUserText();
        }

        #region
        //vars
        int totalMinA = 0;
        int totalMinB = 0;
        int bookedMinA = 0;
        int bookedMinB = 0;
        //Init or load the list
        //Init the apppointment2 table
        void InitAppointTab()
        {
            string device = this.coboxDevice.SelectedItem.ToString();
            string dat = this.datPicker.Value.ToShortDateString();
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

        bool isLoaded = false;
        void FreshTheList()
        {
            //Ini the table
            //Init the listview to show data
            string dat = this.datPicker.Value.ToShortDateString();
            appDa = DBAccess.GetAppointment2DA(dat);
            appDS = new DataSet();
            appDa.Fill(appDS, "appointment2");
            DataRow[] rows = appDS.Tables["appointment2"].Select();

            FillToListview(rows, ref this.listVappoint);
            isLoaded = true;
        }

        void SetTbarText()
        {
            this.lbTbarA.Text = "Booked/Total:" + bookedMinA * 10 + "/" + totalMinA;
            this.lbTbarB.Text = "Booked/Total:" + bookedMinB * 10 + "/" + totalMinB;
        }

        void SetUserText()
        {
            this.lbUsr.Text = "Current User#" + DBAccess.currentuseranme;
        }

        //update minutes profile from users table
        void SetTotalMinutesFromUserProfile()
        {
            totalMinA = UserOps.UserProfile.TimeA;
            totalMinB = UserOps.UserProfile.TimeB;
        }

        //Update minutes profile from timesheet table
        void SetTotalMinsFromHolidaysTab(DateTime dat, string timecode)
        {
            timesheet tsops = new timesheet();
            TimeUserProfiles pros = tsops.UpdateMins(dat, timecode);
            totalMinA = pros.TimeA;
            totalMinB = pros.TimeB;
        }

        //Refresh time on load schedule
        void RefreshUserTimeProfile()
        {
            //Get the users' profile
            //Saturday total time rules
            //Sunday totaltime rules
            //Holiday totaltime rules
            bool IsHoliday = false;
            string timecode = "";
            timesheet tsh = new timesheet();
            DateTime dat = datPicker.Value;
            if (tsh.TheDayIsSat(dat))
            {
                IsHoliday = true;
                timecode = "sat001";
            }
            else if (tsh.TheDayIsSun(dat))
            {
                IsHoliday = true;
                timecode = "sun001";
            }
            else if (tsh.TheDayInHolidays(dat))
            {
                IsHoliday = true;
                timecode = "pub001";
            }

            if (IsHoliday)
            {
                //Set totaltime for holidays
                SetTotalMinsFromHolidaysTab(DateTime.Now, timecode);
            }
            else
            {
                //Set totaltime for normal days
                SetTotalMinutesFromUserProfile();
            }
        }

        void SetBookedMinutesFromDS()
        {
            //Get the booked minutes
            string filterBookMinA = "username='" + DBAccess.currentuseranme + "' and order >=48 and order<=137";
            string filterBookMin = "username='" + DBAccess.currentuseranme + "'";
            bookedMinA = appDS.Tables["appointment2"].Select(filterBookMinA).Count();
            bookedMinB = appDS.Tables["appointment2"].Select(filterBookMin).Count() - bookedMinA;
        }

        void ClearMinutes()
        {
            totalMinA = 0;
            totalMinB = 0;
            bookedMinA = 0;
            bookedMinB = 0;
        }



        //update to db by cid
        void updateDSByCID(int[] cids)
        {
            foreach (int cid in cids)
            {
                appDS.Tables["appointment2"].Select("id=" + cid)[0]["username"] = DBAccess.currentuseranme;
            }
        }

        //update listview item
        void updateListByIDs(int[] indx)
        {
            foreach (int id in indx)
            {
                this.listVappoint.Items[id].SubItems[5].Text = DBAccess.currentuseranme;
            }
        }

        //uncheck listview item
        void uncheckListByIDs(int[] indx)
        {
            foreach (int id in indx)
            {
                this.listVappoint.Items[id].Checked = false;
            }
        }


        //Get current order
        int ReturnTimeOrder(DateTime dat)
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
                if (mymin >= minlist[i])
                {
                    minoffset = i;
                }
                else
                {
                    break;
                }
            }

            return location + minoffset;
        }

        //Legal order book rule
        bool BookRuleAllowed(int toChangeOrder, int timeOrder)
        {
            if (toChangeOrder <= timeOrder)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Legal order unbook rule
        bool UnbookRuleAllowed(int toChangeOrder, int timeOrder)
        {
            if (toChangeOrder > timeOrder + 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //reload listview
        void FillToListview(DataRow[] appRows, ref ListView listVappoint)
        {
            int timeOrder = ReturnTimeOrder(DateTime.Now);

            listVappoint.Items.Clear();

            int i = 0;
            foreach (DataRow row in appRows)
            {
                listVappoint.Items.Add(row[0].ToString());
                listVappoint.Items[i].SubItems.Add(row[1].ToString());
                listVappoint.Items[i].SubItems.Add(row[2].ToString());
                listVappoint.Items[i].SubItems.Add(row[3].ToString());
                listVappoint.Items[i].SubItems.Add(row[4].ToString());
                listVappoint.Items[i].SubItems.Add(row[5].ToString());
                listVappoint.Items[i].SubItems.Add(row[6].ToString());
                listVappoint.Items[i].SubItems.Add(row[7].ToString());

                //control the book/unbook area
                //timeOrder is current timeslot; timeOrder+6, to set offset +1hour
                if (Convert.ToInt32(row[0]) <= timeOrder + timeOrderOffset && row[2].ToString() == DateTime.Now.ToShortDateString())
                {
                    listVappoint.Items[i].BackColor = Color.LightGray;
                }
                else
                {

                }
                i++;

                //Debug.WriteLine("wait");
            }
        }

        #endregion

        private void ListVappoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int timeOrder = ReturnTimeOrder(DateTime.Now);
        }

        private void DatPicker_ValueChanged(object sender, EventArgs e)
        {
            //this.listVappoint.Clear();
            if (DBAccess.currentuseranme != DBAccess.nullname)
            {
                //ini table
                InitAppointTab();
                //Reload data to listview
                FreshTheList();
                //Get minutes
                SetBookedMinutesFromDS();
                //Refersh the user time profile
                RefreshUserTimeProfile();

                //show text
                SetTbarText();
            }
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            this.datPicker.MinDate = DateTime.Now;
            this.datPicker.MaxDate = DateTime.Now.AddDays(1);
        }
    }
}
