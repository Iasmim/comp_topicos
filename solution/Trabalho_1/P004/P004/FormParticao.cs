using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P004
{

    public partial class FormParticao : Form
    {
        /* Partição. Uma partição de um conjunto S 
         * é uma coleção de subconjuntos disjuntos
         * e não vazios, de S, cuja união é igual 
         * a S. Por exemplo, { {1,3},{2,4,7}, {5}, 
         * {6,8} } é uma partição de {1,2,3,4,5,6,7,8}.
         * O conjunto {6,8} é um dos blocos da partição. 
         * Escreva um programa que imprima uma lista de 
         * todas as partições de um conjunto {1,2,3,...,n}.*/
        StringBuilder str;
        StringBuilder part;
        public FormParticao()
        {
            InitializeComponent();
            str = new StringBuilder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int begin = int.Parse(textBox1.Text);
            int end = int.Parse(textBox2.Text);
            for (int k = begin; k < end; k++)
            {
                for (int i = begin; i < end; i++)
                {
                    var list = CreatePartition(i, end, k);
                    GetToPrint(list);
                    str.AppendLine(String.Format("({0})", part));
                }
            }
            textBox3.Text = str.ToString();
           
        }

        public List<ClassNumber> CreatePartition(int i, int end, int size)
        {
            List<ClassNumber> list = new List<ClassNumber>();
            for (int j = i; j < end; j++)
            {
                ClassNumber number = new ClassNumber();
                number.number = new List<int>();
                int k = 0;
                number.number.Add(i);
                k = j + 1;
                while (number.number.Count < size)
                {
                    number.number.Add(k);
                    k++;
                }
                list.Add(number);
            }

            return list;
        }

        public StringBuilder GetToPrint(List<ClassNumber> list)
        {
            part = new StringBuilder();
            foreach (var item in list)
            {
                if (!String.IsNullOrEmpty(item.number.ToString()))
                    part.Append(String.Format("[{0}]", String.Join(",", item.number)));
            }

            return part;
        }
    }
}
