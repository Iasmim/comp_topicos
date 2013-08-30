using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using P011.CE;

namespace P011
{
    public partial class FormFuncionario : Form
    {
        CE_Funcionario funci;
        public FormFuncionario()
        {
            InitializeComponent();
            funci = new CE_Funcionario("Iasmim Souza da Cunha",3000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = funci.setNome;
            label2.Text = funci.setSalario.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funci.aumentarSalario(double.Parse(textBox1.Text));
            label2.Text = funci.setSalario.ToString();
        }
    }
}
