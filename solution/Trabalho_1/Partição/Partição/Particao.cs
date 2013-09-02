using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partição
{
    class Particao
    {
        public void imprimirParticao(int[] particao, int n)
        {
            int numeroSubconjunto = 1;

            int i;

            for (i = 0; i < n; i++)
            {
                if (particao[i] > numeroSubconjunto)
                {
                    numeroSubconjunto = particao[i];
                }
            }

            int j;

            for (j = numeroSubconjunto; j >= 1; j--)
            {
                int impressao = 0;
                Console.Write("{");

                for (i = 0; i < n; i++)
                {
                    if (particao[i] == j)
                    {
                        impressao++;

                        if (impressao >= 2)
                        {
                            Console.Write("," + (i + 1));
                        }
                        else
                        {
                            Console.Write(i + 1);
                        }
                    }
                }
                Console.Write("}");
            }
            Console.WriteLine();
        }

        public bool buscarParticoes(int[] particao, int[] maiores, int n)
        {
            int i = 0;

            ++particao[i];

            while ((i < (n - 1)) && (particao[i] > maiores[i] + 1))
            {
                particao[i] = 1;
                ++i;
                ++particao[i];
            }

            if (i == (n - 1))
            {
                return false;
            }

            int maximo = particao[i];

            for (i = i - 1; i >= 0; --i)
            {
                maiores[i] = maximo;
            }

            return true;
        }

        public static void Main(string[] args)
        {
            Particao particoes = new Particao();

            Console.Write("Digite um número inteiro positivo: ");
            int n = int.Parse(Console.ReadLine());

            int[] particao = new int[n];
            int[] maiores = new int[n];

            int i;

            for (i = 0; i < n; i++)
            {
                particao[i] = 1;
                maiores[i] = 1;
            }

            Console.Write("\nPartição[1] = ");
            particoes.imprimirParticao(particao, n);

            int j = 2;

            while (particoes.buscarParticoes(particao, maiores, n))
            {
                Console.Write("Partição[{0}] = ", j);
                particoes.imprimirParticao(particao, n);
                j++;
            }

            Console.Write("\nPressione qualquer tecla para sair!");
            Console.ReadKey();
            
        }
    }
}
