using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P001.CE
{
    public class CE_Bola
    {
        public String Cor { get; set; }
        public Single Circunferência { get; set; }
        public String Material { get; set; }

        public void trocaCor(String cor)
        {
            this.Cor = cor;
        }
        public void trocaCircunferencia(Single circunferencia)
        {
            this.Circunferência = circunferencia;
        }
        public void trocaMaterial(String material)
        {
            this.Material = material;
        }
        public String mostraCor()
        {
            return this.Cor;
        }
        public Single mostraCircunferencia()
        {
            return this.Circunferência;
        }
        public String mostraMaterial()
        {
            return this.Material;
        }
    }
}
