using System;
using System.Windows.Forms;


namespace LabRegisterV1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //keep single window
            bool singleThrea = false;
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, Application.ProductName, out singleThrea);
            if (singleThrea)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMain());

                mutex.ReleaseMutex();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
