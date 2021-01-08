using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Odd_and_Even_Card_Game
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartUp());
        }
    }
}
