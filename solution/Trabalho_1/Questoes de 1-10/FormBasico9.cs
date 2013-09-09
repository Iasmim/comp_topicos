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
    /*
    Classe Ponto e Retangulo: Faça um programa completo utilizando funções e classes que:
Possua uma classe chamada Ponto, com os atributos x e y.
Possua uma classe chamada Retangulo, com os atributos largura e altura.
Possua uma função para imprimir os valores da classe Ponto
Possua uma função para encontrar o centro de um Retângulo.
Você deve criar alguns objetos da classe Retangulo.
Cada objeto deve ter um vértice de partida, por exemplo, o vértice inferior 
esquerdo do retângulo, que deve ser um objeto da classe Ponto.
A função para encontrar o centro do retângulo deve retornar o valor para um
objeto do tipo ponto que indique os valores de x e y para o centro do objeto.
O valor do centro do objeto deve ser mostrado na tela
Crie um menu para alterar os valores do retângulo e imprimir o centro deste retângulo.
     
    */
    public partial class FormBasico9 : Form
    {
        CE_Ponto ponto;
        CE_Retangulo retangulo;
        public FormBasico9()
        {
            InitializeComponent();
            ponto = new CE_Ponto();
            retangulo = new CE_Retangulo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            retangulo.vertice = new CE_Ponto() {x = int.Parse(textBox2.Text)/2,y = int.Parse(textBox1.Text)/2 };

            label6.Text = "("+retangulo.vertice.x.ToString()+",";
            label7.Text = retangulo.vertice.y.ToString()+")";
        }
    }
}
