using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao14
{
    class Funcionario
    {
        string nome { get; set; }
        double salario { get; set; }

        public Funcionario(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public void aumentarSalario(double aumento)
        {
            this.salario = this.salario + this.salario * (aumento / 100);
        }

        public void mostrarDados()
        {
            Console.WriteLine("\nDados do funcionário:");
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Salário: R$ " + this.salario + "\n");
        }

        public static void Main(string[] args)
        {
            string nome;
            double salario;
            int opcao;

            Console.Write("Digite o nome do funcionário: ");
            nome = Console.ReadLine();
            Console.Write("Digite o valor do salário do funcionário: ");
            salario = double.Parse(Console.ReadLine());

            Funcionario funcionario = new Funcionario(nome, salario);

            do
            {
                funcionario.mostrarDados();

                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("(1) Aumentar o salário");
                Console.WriteLine("(2) Sair\n");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Porcentagem de aumento do salário: ");
                        double porcentagem = double.Parse(Console.ReadLine());
                        funcionario.aumentarSalario(porcentagem);
                        break;
                }
            } while (opcao != 2);
        }
    }
}
