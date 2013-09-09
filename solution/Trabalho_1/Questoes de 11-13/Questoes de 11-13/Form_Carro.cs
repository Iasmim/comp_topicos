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

    /*Classe carro: Implemente uma classe chamada Carro com as seguintes propriedades: 
a.	Um veículo tem um certo consumo de combustível (medidos em km / litro) e uma certa quantidade de combustível no tanque. 
b.	O consumo é especificado no construtor e o nível de combustível inicial é 0. 
c.	Forneça um método andar( ) que simule o ato de dirigir o veículo por uma certa distância, reduzindo o nível de combustível no tanque de gasolina. 
d.	Forneça um método obterGasolina( ), que retorna o nível atual de combustível. 
e.	Forneça um método adicionarGasolina( ), para abastecer o tanque. Exemplo de uso: 
f.	meuFusca = Carro(15);           # 15 quilômetros por litro de combustível. 
g.	meuFusca.adicionarGasolina(20); # abastece com 20 litros de combustível. 
h.	meuFusca.andar(100);            # anda 100 quilômetros.
meuFusca.obterGasolina()        # Imprime o combustível que resta no tanque.*/

    public partial class Form_Carro : Form
    {
        CE_Carro meucarro;
        public Form_Carro()
        {
            InitializeComponent();
            meucarro = new CE_Carro(15);
            progressBar1.Visible = false;
        }

        private void CaluculateAll(System.Windows.Forms.ProgressBar progressBar)
        {
            progressBar1.Visible = true;

            progressBar.Maximum = 100000;
            progressBar.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                double pow = Math.Pow(j, j); //Calculation
                progressBar.PerformStep();
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            CaluculateAll(progressBar1);
            meucarro.Andar(!String.IsNullOrEmpty(textBox1.Text) ?int.Parse(textBox1.Text):0);
            label3.Text = "OK!";
            progressBar1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = meucarro.obterGasolina().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            meucarro.adicionarGasolina(!String.IsNullOrEmpty(textBox2.Text) ? int.Parse(textBox2.Text) : 0);
            System.Windows.Forms.MessageBox.Show(this,"Obrigado meu patrão!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox1.Text = null;
            label2.Text = null;
            label3.Text = null;
        }
    }
}
