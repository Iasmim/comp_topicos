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
    public partial class FormBasico5 : Form
    {
        CE.CE_ContaCorrente conta;
        public FormBasico5()
        {
            InitializeComponent();
            conta = new CE.CE_ContaCorrente(0475, "Iasmim S. Cunha", 1000);

            label4.Text = conta.nconta.ToString();
            label5.Text = conta.correntista;
            label6.Text = conta.saldo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conta.alterarNome(textBox2.Text);

            label4.Text = conta.nconta.ToString();
            label5.Text = conta.correntista;
            if (radioButton1.Checked)
                conta.saque(double.Parse(textBox3.Text));
            else if (radioButton2.Checked)
                conta.deposito(double.Parse(textBox3.Text));
            label6.Text = conta.saldo.ToString();


        }
    }
}
