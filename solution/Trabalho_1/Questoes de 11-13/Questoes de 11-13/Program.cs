using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace P011
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
                    Application.Run(new Form_Carro());
                    break;
                case "1":
                    Application.Run(new Form_Funcionario());
                    break;
                case "2":
                    Application.Run(new Form_Invertimento());
                    break;
                default:
                    break;
            }
        }
    }
}
