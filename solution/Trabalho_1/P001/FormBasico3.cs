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
    /*Classe Retangulo: Crie uma classe que modele um retangulo:

Atributos: LadoA, LadoB (ou Comprimento e Largura, ou Base e Altura, a escolher)
Métodos: Mudar valor dos lados, Retornar valor dos lados, calcular Área e calcular Perímetro;
Crie um programa que utilize esta classe. Ele deve pedir ao usuário que informe as
     * medidades de um local. Depois, deve criar um objeto com as medidas e calcular a quantidade
     * de pisos e de rodapés necessárias para o local.*/
    public partial class FormBasico3 : Form
    {
        CE.CE_Retangulo retangulo;
        public FormBasico3()
        {
            InitializeComponent();
            retangulo = new CE.CE_Retangulo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = retangulo.retornaArea().ToString();
            label6.Text = retangulo.retornaPerimetro().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            retangulo.trocarBase(int.Parse(textBox1.Text));
            label8.Text =  retangulo.mostraBase().ToString();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            retangulo.trocarAltura(int.Parse(textBox2.Text));
            label7.Text = retangulo.mostraAltura().ToString();
        }
    }
}
