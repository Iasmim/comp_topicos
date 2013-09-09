using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Basicas_1_17.CE;

namespace Basicas_1_17
{
    public partial class FormBasico10 : Form
    {
        CE_BombaCombustivel bomba;
        public double litros;
        public double reais;
        public FormBasico10()
        {
            InitializeComponent();
            bomba = new CE_BombaCombustivel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             if (radioButton1.Checked)
             {
                 label9.Text = bomba.abastecerPorValor(double.Parse(textBox1.Text)).ToString();
                 label5.Text = bomba.alterarQuantidadeCombustivel(double.Parse(label9.Text)).ToString();
                 label8.Text = "LITROS ABASTECIDOS";
             }
             else
             {
                 label9.Text = bomba.abastecerPorLitro(double.Parse(textBox1.Text)).ToString();
                 label5.Text = bomba.alterarQuantidadeCombustivel(double.Parse(textBox1.Text)).ToString();
                 label8.Text = "REAIS ABASTECIDOS";
             }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bomba.alterarCombustivel(comboBox1.SelectedIndex + 1);
            bomba.alterarValor();
            
        }
    }
}
