using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace P001
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                switch (args[0])
                {
                    case "0":
                        Application.Run(new FormBasico1());
                        break;
                    case "1":
                        Application.Run(new FormBasico2());
                        break;
                    case "2":
                        Application.Run(new FormBasico3());
                        break;
                    case "3":
                        Application.Run(new FormBasico4());
                        break;
                    case "4":
                        Application.Run(new FormBasico5());
                        break;
                    default:
                        break;
                }
        }
    }
}
