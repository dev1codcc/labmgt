using System.Runtime.InteropServices;

namespace LabLocker
{
    class LockWinOps
    {
        public const int SWP_HIDEWINDOW = 0x80;
        public const int SWP_SHOWWINDOW = 0x40;

        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(
            int hWnd,                           //   handle   to   window    
            int hWndInsertAfter,     //   placement-order   handle    
            short X,                                   //   horizontal   position    
            short Y,                                   //   vertical   position    
            short cx,                                 //   width    
            short cy,                                 //   height    
            uint uFlags                         //   window-positioning   options    
        );
        [DllImport("user32.dll")]
        public static extern int FindWindow(
            string lpClassName,     //   class   name    
            string lpWindowName     //   window   name    
        );


    }
}
