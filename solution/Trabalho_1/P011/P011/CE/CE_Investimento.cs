using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P011.CE
{
    /*Classe Conta de Investimento: Faça uma classe contaInvestimento
        * que seja semelhante a classe contaBancaria, 
        * com a diferença de que se adicione um atributo 
        * taxaJuros. Forneça um construtor que configure
        * tanto o saldo inicial como a taxa de juros. 
        * Forneça um método adicioneJuros (sem parâmetro explícito)
        * que adicione juros à conta. Escreva um programa que construa 
        * uma poupança com um saldo inicial de R$1000,00 e uma taxa de
        * juros de 10%. Depois aplique o método adicioneJuros() cinco
        * vezes e imprime o saldo resultante. */
    public class CE_Investimento
    {
        public CE_Investimento()
        {
            taxaJuros = 0.1;
            saldoInicial = 1000;
        }
        public double taxaJuros { get; set; }
        public double saldoInicial { get; set; }
        public void adicioneJuros()
        {
            saldoInicial = saldoInicial + (taxaJuros * saldoInicial);
        }
    }
}
