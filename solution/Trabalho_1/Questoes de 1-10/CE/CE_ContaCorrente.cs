using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basicas_1_17.CE
{
    /*Classe Conta Corrente: Crie uma classe para implementar uma conta corrente.
     * A classe deve possuir os seguintes atributos: número da conta, nome do correntista
     * e saldo. Os métodos são os seguintes: alterarNome, depósito e saque; No construtor,
     * saldo é opcional, com valor default zero e os demais atributos são obrigatórios.*/
   public class CE_ContaCorrente
    {
       public CE_ContaCorrente(int nconta,string correntista,double saldo)
       {
           this.nconta = nconta;
           this.correntista = correntista;
           this.saldo = saldo;
       }
       public int nconta { get; set; }
       public string correntista { get; set; }
       public double saldo { get; set; }

       public void alterarNome(string correntista)
       {
          this.correntista = correntista;
       }
       public void deposito(double dinheiro)
       {
           this.saldo = this.saldo + dinheiro;
       }
       public void saque(double dinheiro)
       {
           this.saldo = this.saldo - dinheiro;
       }

    }
}
