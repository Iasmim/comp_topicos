using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basicas_1_17.CE
{
    /*Classe Pessoa: Crie uma classe que modele uma pessoa:

Atributos: nome, idade, peso e altura
Métodos: Envelhercer, engordar, emagrecer, crescer.
     * Obs: Por padrão, a cada ano que nossa pessoa
     * envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.*/
   public class CE_Pessoa
    {
       public CE_Pessoa(String nome,int idade,double altura,double peso)
       {
           this.Nome = nome;
           this.Idade = idade;
           this.Altura = altura;
           this.Peso = peso;
       }
       public String Nome { get; set; }
       public int Idade { get; set; }
       public double Altura { get; set; }
       public double Peso { get; set; }
       public void envelhecer()
       { 
           Altura = Altura + 0.5;
       }
       public void emagrecer(int peso)
       {
           Peso = Peso - peso;
       }
       public void engordar(int peso)
       {
           Peso = Peso + peso;
       }
       public void crescer(int altura = 0)
       {
           Altura = Altura + altura;
       }
    }
}
