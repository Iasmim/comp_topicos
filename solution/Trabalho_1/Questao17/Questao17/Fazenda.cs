using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao17
{
    class Fazenda
    {
        List<Animal> animais { get; set; }
        Proprietario dono { get; set; }

        public Fazenda(Proprietario dono, List<Animal> animais)
        {
            this.dono = dono;
            this.animais = animais;
        }

        public void mostrarAnimais()
        {
            Console.WriteLine("\nNome do dono: " + this.dono.getNome());

            if (this.animais.Count != 0)
            {
                foreach (Animal animal in this.animais)
                {
                    Console.WriteLine("\nDados do " + animal.getNome() + ":");
                    Console.WriteLine("Tipo: " + animal.GetType().Name);
                    Console.WriteLine("Idade: " + animal.getIdade());
                    Console.WriteLine("Saúde: " + animal.getSaude());
                    Console.WriteLine("Fome: " + animal.getFome());
                    Console.WriteLine("Humor: " + animal.getHumor());
                    Console.WriteLine("Tédio: " + animal.getTedio() + "\n");
                }
            }
            else
            {
                Console.WriteLine("\nA fazenda não tem animais! Compre animais!");
            }
        }

       
    }

    class Proprietario
    {
        string nome { get; set; }

        public Proprietario(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }

        public void alimentarAnimais(List<Animal> animais)
        {
            if (animais.Count != 0)
            {
                foreach (Animal animal in animais)
                {
                    animal.comer();
                }
            }
        }

        public void brincarComAnimais(List<Animal> animais)
        {
            if (animais.Count != 0)
            {
                foreach (Animal animal in animais)
                {
                    animal.comer();
                }
            }
            else
            {
                Console.WriteLine("A fazenda não tem animais!");
            }
        }

        public void ouvirAnimais(List<Animal> animais)
        {
            if (animais.Count != 0)
            {
                foreach (Animal animal in animais)
                {
                    Console.WriteLine(animal.GetType().Name + " " + animal.getNome() + ": " + animal.emitirSom());
                }
            }
            else
            {
                Console.WriteLine("A fazenda não tem animais!");
            }
        }

        public void comprarAnimal(Animal animal, List<Animal> animais)
        {
            animais.Add(animal);
        }
    }

    class Galo : Animal
    {
        public Galo(string nome, int idade) : base(nome, idade) { }
        public override string emitirSom()
        {
            return "Cócórocó Cócórocó";
        }
    }

    class Vaca : Animal
    {
        public Vaca(string nome, int idade) : base(nome, idade) { }

        public override string emitirSom()
        {
            return "Mooooommm";
        }
    }

    class Cavalo : Animal
    {
        public Cavalo(string nome, int idade) : base(nome, idade) { }
        public override string emitirSom()
        {
            return "Rim rim rim";
        }
    }

    class Animal
    {
        string nome;
        int idade;
        int fome { get; set; }
        int saude { get; set; }
        int tedio { get; set; }

        public Animal(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;

            Random random = new Random();
            this.fome = random.Next(11);
            this.saude = random.Next(11);
            this.tedio = random.Next(11);
        }

        public string getNome()
        {
            return nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
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

        public void comer()
        {
            if (this.fome == 0)
            {
                Console.WriteLine(this.nome + " sem fome!");
            }
            else
            {
                Console.Write("Quantidade de comida para " + this.getNome() + "(" + this.GetType().Name + "): ");
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
                Console.Write("Tempo da brincadeira com " + this.getNome() + "(" + this.GetType().Name + "): ");
                int tempo = int.Parse(Console.ReadLine());
                this.tedio = this.tedio - tempo;
                this.fome = this.fome + tempo;
                if (this.fome > 10)
                    this.fome = 10;
                if (this.tedio < 0)
                    this.tedio = 0;
            }
        }

        public virtual string emitirSom()
        {
            return "";
        }
    }
}
