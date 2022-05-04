using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7_WF_IMC
{
    internal class Calcular
    {
        public double Peso { get; set; }
        public double Altura { get; set; }


        public double IMC()
        {
            return Peso / (Altura * Altura);
        }

    }
}
