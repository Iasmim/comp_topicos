using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P011.CE
{
    public class CE_Carro
    {
        public int consumo;
        public CE_Carro(int consumo)
        {
            this.consumo = consumo;
        }
        public double combustivel { get; set; }
        public void Andar(int quilometro)
        {
            combustivel = combustivel - (quilometro / consumo);
        }
        public double obterGasolina()
        {
            return combustivel;
        }

        public void adicionarGasolina(int gasolina)
        {
            combustivel = combustivel + gasolina;
        }
    }
}
