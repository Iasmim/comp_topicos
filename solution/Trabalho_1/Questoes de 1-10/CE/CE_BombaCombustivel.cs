using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basicas_1_17.CE
{
    /*
     Classe Bomba de Combustível: Faça um programa completo utilizando classes e métodos que:
    Possua uma classe chamada bombaCombustível, com no mínimo esses atributos:
    tipoCombustivel.
    valorLitro
    quantidadeCombustivel
    Possua no mínimo esses métodos:
    abastecerPorValor( ) – método onde é informado o valor a ser abastecido 
    e mostra a quantidade de litros que foi colocada no veículo
    abastecerPorLitro( ) – método onde é informado a quantidade em litros 
    de combustível e mostra o valor a ser pago pelo cliente.
    alterarValor( ) – altera o valor do litro do combustível.
    alterarCombustivel( ) – altera o tipo do combustível.
    alterarQuantidadeCombustivel( ) – altera a quantidade de combustível restante na bomba.
    OBS: Sempre que acontecer um abastecimento é necessário atualizar a 
    quantidade de combustível total na bomba.
     */
    public class CE_BombaCombustivel
    {
        public CE_BombaCombustivel()
        {
            quantidadeCombustivel = 100.0;
        }
        public double valorLitro { get; set; }
        public int tipoCombustivel { get; set; }
        public double quantidadeCombustivel { get; set; }

        public double alterarQuantidadeCombustivel(double litro)
        {
          return quantidadeCombustivel = quantidadeCombustivel - litro;
        }

        public void alterarCombustivel(int tipo)
        {
            tipoCombustivel = tipo;
        
        }
        public void alterarValor()
        {
            /*1- gasolina 2.98 
              2- alcool 2.39        
              3-  diesel 2.35*/
            if (tipoCombustivel == 1)
                this.valorLitro = 2.98;
            else if (tipoCombustivel == 2)
                this.valorLitro = 2.39;
            else if (tipoCombustivel == 3)
                this.valorLitro = 2.35;
        }

        public double abastecerPorValor(double valor)
        {
            if (valorLitro != 0)
                return valor / valorLitro;
            else
                return 0;
        }
        public double abastecerPorLitro(double litro)
        {
            if (litro != 0)
                return valorLitro * litro;
            else
                return 0;
        }
    }
}
