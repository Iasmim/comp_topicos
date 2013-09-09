using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P011.CE
{
    public class CE_Funcionario
    {
        /*Classe Funcionário: Implemente a 
         * classe Funcionário. Um empregado 
         * tem um nome (um string) e um salário(um double). 
         * Escreva um construtor com dois parâmetros 
         * (nome e salário) e métodos para devolver nome
         * e salário. Escreva um pequeno programa que 
         * teste sua classe. 
        •  Aprimore a classe do exercício
         * anterior para adicionar o 
         * método aumentarSalario (porcentualDeAumento) 
         * que aumente o salário do funcionário em uma 
         * certa porcentagem. 
        •	Exemplo de uso: 
        •	  harry=funcionário("Harry",25000)
              harry.aumentarSalario(10)
*/
        String nome;
        double salario;
        public CE_Funcionario(String nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }
        public String setNome
        {
            get { return nome; }
        }
        public double setSalario
        {
            get { return salario; }
        }

        public void aumentarSalario(double aumento)
        {
            salario = salario + ((aumento/100) * salario);
        }
    }
}
