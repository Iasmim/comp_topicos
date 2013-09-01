using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao16
{
    class Tamagushi3
    {
        string nome { get; set; }
        int idade { get; set; }
        int fome { get; set; }
        int saude { get; set; }
        int tedio { get; set; }

        public Tamagushi3(string nome, int idade, int fome, int saude, int tedio)
        {
            this.nome = nome;
            this.idade = idade;
            this.fome = fome;
            this.saude = saude;
            this.tedio = tedio;
        }

        public string getFome()
        {
            if (this.fome == 0)
            {
                return "Sem fome";
            }
            else
            {
                if (this.fome <= 3)
                {
                    return "Baixa";
                }
                else
                {
                    if (this.fome <= 6)
                    {
                        return "Moderada";
                    }
                    else
                    {
                        return "Alta";
                    }
                }
            }
        }

        public string getSaude()
        {
            if (this.saude == 0)
            {
                return "Muito mal";
            }
            else
            {
                if (this.saude <= 3)
                {
                    return "Mal";
                }
                else
                {
                    if (this.saude <= 6)
                    {
                        return "Bem";
                    }
                    else
                    {
                        return "Muito bem";
                    }
                }
            }
        }

        public string getTedio()
        {
            if (this.tedio <= 3) 
                return "Sem tédio";
            else
                return "Entediado";
        }

        public string getHumor()
        {
            if (((10 - this.fome) + this.saude) / 2 >= 8)
            {
                return "Excelente";
            }
            else
            {
                if (((10 - this.fome) + this.saude) / 2 >= 4)
                {
                    return "Bom";
                }
                else
                {
                    return "Péssimo";
                }
            }
        }

        public void setFome(int fome)
        {
            if (fome < 0 || fome > 10)
            {
                do
                {
                    Console.WriteLine("Informe um nível válido de fome (0-10)!");
                    fome = int.Parse(Console.ReadLine());
                } while (fome < 0 || fome > 10);
            }

            this.fome = fome;
        }

        public void setSaude(int saude)
        {
            if (saude < 0 || saude > 10)
            {
                do
                {
                    Console.WriteLine("Informe um nível válido de saúde (0-10)!");
                    saude = int.Parse(Console.ReadLine());
                } while (saude < 0 || saude > 10);
            }

            this.saude = saude;
        }

        public void setTedio(int tedio)
        {
            if (tedio < 0 || tedio > 10)
            {
                do
                {
                    Console.WriteLine("Informe um nível válido de tédio (0-10)!");
                    saude = int.Parse(Console.ReadLine());
                } while (tedio < 0 || tedio > 10);
            }

            this.tedio = tedio;
        }

        public void alimentar()
        {
            if (this.fome == 0)
            {
                Console.WriteLine(this.nome + " sem fome!");
            }
            else
            {
                Console.Write("Quantidade de comida: ");
                int comida = int.Parse(Console.ReadLine());
                this.fome = this.fome - comida;
                this.saude = this.saude + (comida - 3);
                this.tedio = this.tedio + 1;
                if (this.fome < 0)
                    this.fome = 0;
            }
        }

        public void brincar()
        {
            if (this.tedio <= 3)
            {
                Console.WriteLine(this.nome + " não está entediado!");
            }
            else
            {
                Console.Write("Tempo da brincadeira: ");
                int tempo = int.Parse(Console.ReadLine());
                this.tedio = this.tedio - tempo;
                this.fome = this.fome + tempo;
                if (this.fome > 10)
                    this.fome = 10;
                if (this.tedio < 0)
                    this.tedio = 0;
            }
        }

        public void mostrarDados()
        {
            Console.WriteLine("\nDados do Tamagushi:");
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Idade: " + this.idade);
            Console.WriteLine("Saúde: " + this.getSaude());
            Console.WriteLine("Fome: " + this.getFome());
            Console.WriteLine("Humor: " + this.getHumor());
            Console.WriteLine("Tédio: " + this.getTedio() + "\n");
        }

        public void mostrarDadosReais()
        {
            Console.WriteLine("\nDados reais do Tamagushi:");
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Idade: " + this.idade);
            Console.WriteLine("Saúde: " + this.saude);
            Console.WriteLine("Fome: " + this.fome);
            Console.WriteLine("Humor: " + this.getHumor());
            Console.WriteLine("Tédio: " + this.tedio + "\n");
        }

        public static void Main(string[] args)
        {
            string nome;
            int idade, fome, saude, tedio, opcao;

            Console.Write("Informe o nome do seu Tamagushi: ");
            nome = Console.ReadLine();
            Console.Write("Informe a idade do seu Tamagushi: ");
            idade = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Informe o nível inicial de fome do seu bichinho (0-10): ");
                fome = int.Parse(Console.ReadLine());
            } while (fome < 0 || fome > 10);

            do
            {
                Console.Write("Informe o nível inicial de saúde do seu bichinho (0-10): ");
                saude = int.Parse(Console.ReadLine());
            } while (saude < 0 || saude > 10);

            do
            {
                Console.Write("Informe o nível inicial de tédio do seu bichinho (0-10): ");
                tedio = int.Parse(Console.ReadLine());
            } while (tedio < 0 || tedio > 10);

            Tamagushi3 bicho = new Tamagushi3(nome, idade, fome, saude, tedio);

            do
            {
                bicho.mostrarDados();

                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("(1) Alimentar o " + bicho.nome);
                Console.WriteLine("(2) Brincar com o " + bicho.nome);
                Console.WriteLine("(3) Sair\n");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        bicho.alimentar();
                        break;
                    case 2:
                        bicho.brincar();
                        break;
                    default:
                        bicho.mostrarDadosReais();
                        break;
                }
            } while (opcao != 3);
        }
    }
}
