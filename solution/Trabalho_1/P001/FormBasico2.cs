using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using P001.CE;
namespace P001
{
    public partial class FormBasico2 : Form
    {
        CE_Quadrado exe2 ;
        public FormBasico2()
        {
            InitializeComponent();
            exe2 = new CE_Quadrado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exe2.MudaValorLado(textBox1.Text);

            label1.Text = exe2.MostraValorLado();
            label2.Text = exe2.CalculaValorLado().ToString();
        }
    }
}
