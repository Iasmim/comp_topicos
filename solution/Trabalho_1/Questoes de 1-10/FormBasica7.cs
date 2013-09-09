using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Basicas_1_17
{
    public partial class FormBasica7 : Form
    {
        CE.CE_Tamagushics tamagushi;
        public FormBasica7()
        {
            InitializeComponent();
            tamagushi = new CE.CE_Tamagushics("TamaGUGU", 3, 4, 10);
            label5.Text = tamagushi.Nome;
            label6.Text = "POUCA";
            label7.Text = "SAUDAVEL";
            label8.Text = tamagushi.Idade.ToString();

            Humor();

        }

        private void Humor()
        {
            if ((tamagushi.Fome + tamagushi.Saude / 2) < 5)
                label9.Text = "TRISTE";
            else if ((tamagushi.Fome + tamagushi.Saude / 2) > 5)
                label9.Text = "FELIZ";
            else
                label9.Text = "DESCONFIADO";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tamagushi.alteraNome(textBox1.Text);
            tamagushi.alteraFome(int.Parse(textBox2.Text));
            tamagushi.alteraSaude(int.Parse(textBox3.Text));
            tamagushi.alteraIdade(int.Parse(textBox4.Text));

            label5.Text = tamagushi.retornaNome();
            label6.Text = tamagushi.retornaFome(int.Parse(textBox2.Text));
            label7.Text = tamagushi.retornaSaude(int.Parse(textBox3.Text));
            label8.Text = tamagushi.retornaIdade().ToString();
            Humor();
        }
    }
}
