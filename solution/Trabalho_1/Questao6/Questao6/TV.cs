using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao6
{
    class TV
    {
        int canal { get; set; }
        int volume { get; set; }

        public TV(int canal, int volume)
        {
            this.canal = canal;
            this.volume = volume;
        }

        public TV()
        {
        }

        public void trocarCanal(int canal)
        {
            if (canal > 0 && canal < 101) 
            {
                this.canal = canal;
            }
            else
            {
                do
                {
                    Console.WriteLine("Digite um canal na faixa válida de 1-100!\n");
                    Console.Write("Ir para o canal: ");
                    canal = int.Parse(Console.ReadLine());
                } while (canal < 0 || canal > 100);

                this.canal = canal;
            }
        }

        public void diminuirCanal()
        {
            if (this.canal == 1)
            {
                Console.WriteLine("Não há um canal válido antes do canal 1!");
            }
            else
            {
                this.canal = this.canal - 1;
            }
        }

        public void aumentarCanal()
        {
            if (this.canal == 100)
            {
                Console.WriteLine("Não há um canal válido depois do canal 100!");
            }
            else
            {
                this.canal = this.canal + 1;
            }
        }

        public void diminuirVolume()
        {
            if (this.volume == 0)
            {
                Console.WriteLine("Volume mínimo!");
            }
            else
            {
                this.volume = this.volume - 1;
            }
        }

        public void aumentarVolume()
        {
            if (this.volume == 100)
            {
                Console.WriteLine("Volume máximo!");
            }
            else
            {
                this.volume = this.volume + 1;
            }
        }

        public void mostrarTVLigada()
        {
            Console.WriteLine("\nTV ligada!");
            Console.WriteLine("Canal: " + this.canal);
            Console.WriteLine("Volume: " + this.volume + "\n");
        }

        public static void Main(string[] args)
        {
            int canal, volume, opcao;

            Console.WriteLine("Para ligar a sua TV, informe:");
            do
            {
                Console.Write("Canal (1-100): ");
                canal = int.Parse(Console.ReadLine());
            } while (canal < 1 || canal > 100);

            do
            {
                Console.Write("Volume: ");
                volume = int.Parse(Console.ReadLine());
            } while (volume < 0 || volume > 100);

            TV tv = new TV(canal, volume);

            do
            {
                tv.mostrarTVLigada();

                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("(1) Trocar de canal");
                Console.WriteLine("(2) Aumentar canal");
                Console.WriteLine("(3) Diminuir canal");
                Console.WriteLine("(4) Aumentar volume");
                Console.WriteLine("(5) Diminuir volume");
                Console.WriteLine("(6) Sair\n");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Ir para o canal: ");
                        int novoCanal = int.Parse(Console.ReadLine());
                        tv.trocarCanal(novoCanal);
                        break;
                    case 2:
                        tv.aumentarCanal();
                        break;
                    case 3:
                        tv.diminuirCanal();
                        break;
                    case 4:
                        tv.aumentarVolume();
                        break;
                    case 5:
                        tv.diminuirVolume();
                        break;
                }

            } while (opcao != 6);
        }
    }
}
