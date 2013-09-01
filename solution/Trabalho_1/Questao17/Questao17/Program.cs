using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao17
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Animal> animais = new List<Animal>();
            Proprietario dono;
            string nomeDono, nomeAnimal;
            int idade, opcao;

            Console.Write("Informe o nome do proprietário: ");
            nomeDono = Console.ReadLine();

            dono = new Proprietario(nomeDono);

            Fazenda fazenda = new Fazenda(dono, animais);

            do
            {
                Console.WriteLine("\nDigite a sua opção:");
                Console.WriteLine("(1) Comprar vaca");
                Console.WriteLine("(2) Comprar cavalo");
                Console.WriteLine("(3) Comprar galo");
                Console.WriteLine("(4) Alimentar animais");
                Console.WriteLine("(5) Brincar com animais");
                Console.WriteLine("(6) Ouvir animais");
                Console.WriteLine("(7) Mostrar dados dos animais");
                Console.WriteLine("(8) Sair\n");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Informe o nome da sua vaca: ");
                        nomeAnimal = Console.ReadLine();
                        Console.Write("Informe a idade da sua vaca: ");
                        idade = int.Parse(Console.ReadLine());
                        Vaca vaca = new Vaca(nomeAnimal, idade);
                        dono.comprarAnimal(vaca, animais);
                        break;
                    case 2:
                        Console.Write("Informe o nome do seu cavalo: ");
                        nomeAnimal = Console.ReadLine();
                        Console.Write("Informe a idade do seu cavalo: ");
                        idade = int.Parse(Console.ReadLine());
                        Cavalo cavalo = new Cavalo(nomeAnimal, idade);
                        dono.comprarAnimal(cavalo, animais);
                        break;
                    case 3:
                        Console.Write("Informe o nome da seu galo: ");
                        nomeAnimal = Console.ReadLine();
                        Console.Write("Informe a idade da seu galo: ");
                        idade = int.Parse(Console.ReadLine());
                        Galo galo = new Galo(nomeAnimal, idade);
                        dono.comprarAnimal(galo, animais);
                        break;
                    case 4:
                        dono.alimentarAnimais(animais);
                        break;
                    case 5:
                        dono.brincarComAnimais(animais);
                        break;
                    case 6:
                        dono.ouvirAnimais(animais);
                        break;
                    case 7:
                        fazenda.mostrarAnimais();
                        break;
                }
            } while (opcao != 8);

        }



    }
}
