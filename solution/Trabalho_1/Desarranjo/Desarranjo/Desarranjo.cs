using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarranjo
{
    class Desarranjo
    {
        List<String> lista;
        List<int[]> conjuntos { get; set; }


        public Desarranjo()
        {
            conjuntos = new List<int[]>();
        }

        public void iniciarBusca(int n)
        {
            int k = n;
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = i;
            }

            lista = new List<string>();

            permutar(v, 0, k);
            this.conjuntos = retornaDesarranjos(n);
        }

        public List<int[]> retornaDesarranjos(int n)
        {
            List<int[]> conj = new List<int[]>();

            for (int i = 0; i < lista.Count; i++)
            {
                int p = 0;
                int[] conjunto = new int[n + 1];

                for (int j = 1; j <= n; j++)
                {
                    char numChar;
                    numChar = lista[i][p];
                    string numString = numChar.ToString();
                    int t = int.Parse(numString);
                    conjunto[j] = t + 1;
                    p = p + 2;
                }
                conj.Add(conjunto);
            }

            return conj;
        }

        public void trocar(int[] v, int i, int j)
        {
            int t;
            t = v[i];
            v[i] = v[j];
            v[j] = t;
        }

        public void rodar(int[] v, int inicio, int n)
        {
            int tmp = v[inicio];
            for (int i = inicio; i < n - 1; i++)
            {
                v[i] = v[i + 1];
            }
            v[n - 1] = tmp;
        }

        public void permutar(int[] v, int inicio, int n)
        {
            if (!lista.Contains(string.Join(",", v)))
                lista.Add(string.Join(",", v));
            if (inicio < n)
            {
                int i, j;
                for (i = n - 2; i >= inicio; i--)
                {
                    for (j = i + 1; j < n; j++)
                    {
                        trocar(v, i, j);
                        permutar(v, i + 1, n);
                    }
                    rodar(v, i, n);
                }
            }
        }

        public void imprimirDesarranjos(int n)
        {
            List<int[]> conjDes = new List<int[]>();

            Console.Write("\nDesarranjos de [");
            for (int j = 1; j <= n; j++)
            {
                if (j == 1)
                {
                    Console.Write(j);
                }
                else
                {
                    Console.Write("," + j);
                }

            }
            Console.WriteLine("]:\n");

            foreach (int[] conj in this.conjuntos)
            {
                int count = 0;
                for (int j = 1; j < conj.Length; j++)
                {

                    if (conj[j] != j)
                    {
                        count = count + 1;
                    }
                }
                if (count == n)
                {
                    conjDes.Add(conj);
                }
            }

            int k = 1;
            foreach (int[] v in conjDes)
            {
                if (k == 1)
                {
                    Console.Write("(");
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("(");
                }
                for (int i = 1; i < v.Length; i++)
                {
                    if (i == 1)
                    {
                        Console.Write(v[i]);
                    }
                    else
                    {
                        Console.Write("," + v[i]);
                    }
                }
                Console.Write(")");
                k++;
            }
        }

        public static void Main(string[] args)
        {
            Desarranjo desarranjo = new Desarranjo();

            Console.Write("Digite um número inteiro positivo N para obter os desarranjos de 1,2,3...N: ");
            int n = int.Parse(Console.ReadLine());
            desarranjo.iniciarBusca(n);

            desarranjo.imprimirDesarranjos(n);

            Console.Write("\n\nPressione qualquer tecla para sair!");
            Console.ReadKey();
        }
    }
}
