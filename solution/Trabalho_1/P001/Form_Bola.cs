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
    public partial class Form_Bola : Form
    {
        CE_Bola exe1;
        public Form_Bola()
        {
            InitializeComponent();
            exe1 = new CE_Bola();
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
