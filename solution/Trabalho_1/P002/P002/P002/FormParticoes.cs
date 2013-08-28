using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P002
{
    public partial class FormParticoes : Form
    {
        StringBuilder str;
        StringBuilder part;

        public FormParticoes()
        {
            InitializeComponent();
            str = new StringBuilder();
        }

        public List<ClassNumber> CreatePartition(int i,int end, int size)
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
                if(!String.IsNullOrEmpty(item.number.ToString()))
                 part.Append(String.Format("[{0}]",String.Join(",", item.number)));
            }

            return part;
        }

        public void CleaningAll()
        {
            str.Clear();
            textBox4.Text = String.Empty;
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CleaningAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int begin = int.Parse(textBox2.Text);
            int end = int.Parse(textBox3.Text);
            for (int i = begin; i < end; i++)
            {
                var list = CreatePartition(i, end, int.Parse(textBox1.Text));
                GetToPrint(list);
                str.AppendLine(String.Format("({0})", part));
            }

            textBox4.Text = str.ToString();
        }
    }
}
