using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P001.CE
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
