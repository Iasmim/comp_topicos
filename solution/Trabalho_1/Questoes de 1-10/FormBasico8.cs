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
    public partial class FormBasico8 : Form
    {
        List<CE.CE_Macaco> macacos;
        public FormBasico8()
        {
            InitializeComponent();
            macacos = new List<CE.CE_Macaco>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in macacos)
            {
                if (item.Nome == comboBox1.Text)
                    item.comer(comboBox2.Text);
            }

            comboBox2.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            macacos.Add(new CE.CE_Macaco() { Nome = textBox1.Text});
            textBox1.Text = "";

            comboBox1.Items.Clear();
            foreach (var item in macacos)
            {
                comboBox1.Items.Add(item.Nome);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in macacos)
            {
                if (item.Nome == comboBox1.Text)
                    item.digerir();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in macacos)
            {
                if (item.Nome == comboBox1.Text)
                {
                    label5.Text = item.Nome;
                    label6.Text = item.verBucho();
                }
            }
        }
    }
}
