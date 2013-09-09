using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Basicas_1_17
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
                    case "7":
                        Application.Run(new FormBasica7());
                        break;
                    case "8":
                        Application.Run(new FormBasico8());
                        break;
                    case "9":
                        Application.Run(new FormBasico9());
                        break;
                    case "10":
                        Application.Run(new FormBasico10());
                        break;
                    default:
                       
                        break;
                       
                }
        }
    }
}
