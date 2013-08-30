using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P011
{
    public partial class FormInvertimento : Form
    {
        /*Classe Conta de Investimento: Faça uma classe contaInvestimento
         * que seja semelhante a classe contaBancaria, 
         * com a diferença de que se adicione um atributo 
         * taxaJuros. Forneça um construtor que configure
         * tanto o saldo inicial como a taxa de juros. 
         * Forneça um método adicioneJuros (sem parâmetro explícito)
         * que adicione juros à conta. Escreva um programa que construa 
         * uma poupança com um saldo inicial de R$1000,00 e uma taxa de
         * juros de 10%. Depois aplique o método adicioneJuros() cinco
         * vezes e imprime o saldo resultante. */
        CE.CE_Investimento investimento;
        public FormInvertimento()
        {
            InitializeComponent();
            investimento = new CE.CE_Investimento();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                investimento.adicioneJuros();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var saldo = investimento.saldoInicial;
            if (saldo < 0)
                label1.ForeColor = Color.Red;
            else
                label1.ForeColor = Color.Blue;

            label1.Text = saldo.ToString();
        }
    }
}
