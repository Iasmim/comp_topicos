using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exe_1.CE
{
   public class Class_exe_2
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
