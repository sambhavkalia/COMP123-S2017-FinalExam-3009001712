using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Sambhav Kalia
 * Date: 17/08/2017
 * StudentID: 300900171
 * Description: This is Main Program
 * Version: 0.1
 */

namespace COMP123_S2017_FinalExam_3009001712
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
