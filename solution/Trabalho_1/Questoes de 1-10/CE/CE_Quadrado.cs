using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basicas_1_17.CE
{
   public class CE_Quadrado
    {
       private int lado { get; set; }

       public void MudaValorLado(String lado)
       {
           this.lado = int.Parse(lado);
       }

       public String MostraValorLado()
       {
           return this.lado.ToString();
       }

       public double CalculaValorLado()
       {
           return this.lado* this.lado;
       }
    }
}
