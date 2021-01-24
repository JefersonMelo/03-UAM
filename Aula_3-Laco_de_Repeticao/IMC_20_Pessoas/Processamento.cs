using System;
using System.Collections.Generic;
using System.Text;

namespace IMC_20_Pessoas
{
    class Processamentos
    {
        public double calcularIMC( double peso, double altura )
        {
            double imc = peso / Math.Pow(altura, 2);
            return imc;
        }
    }
}
