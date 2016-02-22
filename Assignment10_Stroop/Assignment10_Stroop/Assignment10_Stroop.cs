using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Jacob Stroop
CIS 353 - Assignment 10
2/21/16
*/

namespace Assignment10_Stroop
{
    static class Assignment10_Stroop
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GuessANumber());
        }
    }
}
