using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basicas_1_17.CE
{
    /*
     Classe Bichinho Virtual:Crie uma classe que modele um Tamagushi (Bichinho Eletrônico):

Atributos: Nome, Fome, Saúde e Idade b. Métodos: Alterar Nome, Fome, Saúde e Idade; 
     * Retornar Nome, Fome, Saúde e Idade Obs: Existe mais uma informação que devemos
     * levar em consideração, o Humor do nosso tamagushi, este humor é uma combinação
     * entre os atributos Fome e Saúde, ou seja, um campo calculado, então não devemos 
     * criar um atributo para armazenar esta informação por que ela pode ser calculada
     * a qualquer momento.
     */
    public class CE_Tamagushics
    {
        public CE_Tamagushics(String nome, int fome, int saude, int idade)
        {
            this.Nome = nome;
            this.Fome = fome;
            this.Saude = saude;
            this.Idade = idade;
        }


        public String Nome { get; set; }
        public int Fome { get; set; }
        public int Saude { get; set; }
        public int Idade { get; set; }

        public void alteraNome(String nome)
        {
            this.Nome = nome;
        }
        public String retornaNome()
        {
            return this.Nome;
        }
        public void alteraFome(int fome)
        {
            this.Fome = fome;
        }
        public String retornaFome(int fome)
        {
            if (fome <= 3)
                return "POUCA";
            else if (fome == 5)
                return "MÉDIA";
            else if (fome > 5 && fome < 10)
                return "MUITA";
            else
                return "FAMINTO";
        }
        public void alteraSaude(int saude)
        {
            this.Saude = saude;
        }
        public String retornaSaude(int saude)
        {
            if (saude <= 3)
                return "SALDAVEL";
            else if (saude == 5)
                return "MÉDIA";
            else if (saude > 5 && saude < 10)
                return "DOENTE";
            else
                return "MORRENDO";
        }
        public void alteraIdade(int idade)
        {
            this.Idade = idade;
        }
        public int retornaIdade()
        {
            return this.Idade;
        }
    }
}
