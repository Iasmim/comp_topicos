using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P001
{
    public partial class FormBasico4 : Form
    {
        CE.CE_Pessoa pessoa;
        public FormBasico4()
        {
            InitializeComponent();
            pessoa = new CE.CE_Pessoa("Joelton Matos", 18, 1.8, 78);

            label6.Text = pessoa.Nome;
            label7.Text = pessoa.Idade.ToString();
            label9.Text = pessoa.Altura.ToString();
            label8.Text = pessoa.Peso.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            pessoa.Idade = pessoa.Idade + 1;
             label7.Text = pessoa.Idade.ToString();
             if (pessoa.Idade < 21)
                 pessoa.Altura = pessoa.Altura + 0.5;

             label9.Text = pessoa.Altura.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pessoa.Peso = pessoa.Peso + 1;
            label8.Text = pessoa.Peso.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pessoa.Peso = pessoa.Peso - 1;
            label8.Text = pessoa.Peso.ToString();
        }
    }
}
