using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basicas_1_17.CE
{
    /*
     Classe Macaco: Desenvolva uma classe Macaco,
     * que possua os atributos nome e bucho (estomago)
     * e pelo menos os métodos comer(), verBucho() e digerir().
     * Faça um programa ou teste interativamente, criando pelo
     * menos dois macacos, alimentando-os com pelo menos 3 alimentos
     * diferentes e verificando o conteúdo do estomago a cada refeição.
     * Experimente fazer com que um macaco coma o outro. É possível criar um macaco canibal?
     */
    public class CE_Macaco
    {
        public CE_Macaco()
        {
            bucho = new List<string>();
        }
        public String Nome { get; set; }
        public List<String> bucho { get; set; }

        public void comer(String bucho)
        {
            this.bucho.Add(bucho);
        }

        public void digerir()
        {
            this.bucho.Clear();
        }

        public String verBucho()
        {
            return string.Join(",", this.bucho);
        }
    }
}
