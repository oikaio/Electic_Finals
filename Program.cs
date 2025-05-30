using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_POS_Application
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SSS());
            //Application.Run(new POS_Cashier_Interface());
            //Application.Run(new f2());

            //Application.Run(new login ());

            // Application.Run(new Prelim_Exam());
            //Application.Run(new Sampledb());
            //Application.Run(new midtermPOSH());
            Application.Run(new menustrip());
            //Application.Run(new MidtermSSS());
            //Application.Run(new login());
            //Application.Run(new Finals_Activity1());
            //Application.Run(new Finals_Activity2());
            // wahatadfak im a poop shit gay;
        }
    }
}
