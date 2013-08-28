using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Basicos.CE;
namespace Exe_1
{
    public partial class FormExe1 : Form
    {
        Class_exe_1 exe1;
        public FormExe1()
        {
            InitializeComponent();
            exe1 = new Class_exe_1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exe1.trocaCor(textBox1.Text);
            exe1.trocaCircunferencia(Convert.ToSingle(textBox2.Text));
            exe1.trocaMaterial(textBox3.Text);

           label4.Text = exe1.mostraCor();
           label5.Text = exe1.mostraCircunferencia().ToString();
           label6.Text = exe1.mostraMaterial();
        }
    }
}
