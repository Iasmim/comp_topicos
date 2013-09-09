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
                        Application.Run(new Form_Bola());
                        break;
                    case "1":
                        Application.Run(new Form_Quadrado());
                        break;
                    case "2":
                        Application.Run(new Form_Retangulo());
                        break;
                    case "3":
                        Application.Run(new Form_Pessoa());
                        break;
                    case "4":
                        Application.Run(new Form_ContaCorrente());
                        break;
                    default:
                        break;
                }
        }
    }
}
