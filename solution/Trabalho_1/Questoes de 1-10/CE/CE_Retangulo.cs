using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basicas_1_17.CE
{
    public class CE_Retangulo
    {
        public int Altura { get; set; }
        public int Base { get; set; }
        /*questao 9*/
        public CE_Ponto vertice { get; set; }
        public void trocarBase(int Base)
        {
            this.Base = Base;
        }
       
        public int mostraBase()
        {
            return this.Base;
        }
        public void trocarAltura(int Altura)
        {
            this.Altura = Altura;
        }

        public int mostraAltura()
        {
            return this.Altura;
        }
        public int retornaArea()
        {
            return this.Altura* this.Base;
        }
        public int retornaPerimetro()
        {
            return 2*this.Altura + 2*this.Base;
        }
    }
}
