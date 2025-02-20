using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace HomePages
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        int count = 0;
        double ops = 100;
        private void timHome_Tick(object sender, EventArgs e)
        {
            if (count < 50)
            {
                count++;
                if (count % 10 == 0)
                {
                    ops = (100 - count * 1.5) / 100;
                }

                //this.Opacity = ops;
            }
            else
            {
                timHome.Enabled = false;
                //MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
                //Process pr = new Process();
                string appName = System.IO.File.ReadAllText(@"C:\pools\app.name");
                this.Hide();
                Process.Start("C:\\pools\\Release\\" + appName.Trim());
                this.Close();
            }
        }
    }
}
