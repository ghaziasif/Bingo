using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bingo
{
    static class Program
    {
        public static int  win=0;
        public static int[] arr = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        //{1,2,3,4,5,6,7,8,9}
        public static int[] pick = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int[] done = new int[] { 0, 0, 0, 0, 0, 0, 0, 0};
        public static int[] oarr = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static int[] opick = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int[] odone = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int[] opickcheck = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int[] odonecheck = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {    
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Game());
            
        }
       
    }
}
