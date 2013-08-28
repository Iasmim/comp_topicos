using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Exe_1.CE;
namespace Exe_1
{
    public partial class FormExe2 : Form
    {
        Class_exe_2 exe2 ;
        public FormExe2()
        {
            InitializeComponent();
            exe2 = new Class_exe_2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exe2.MudaValorLado(textBox1.Text);

            label1.Text = exe2.MostraValorLado();
            label2.Text = exe2.CalculaValorLado().ToString();
        }
    }
}
