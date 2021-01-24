using System;
using System.Collections.Generic;
using System.Text;

namespace Calculos
{
    class Processamento
    {
        private double num;

        public double Num { get => num; set => num = value; }

        public Processamento( ) { }

        public double numQuadrado( )
        {
            return Math.Pow(Num, 2);
        }

        public double numCubo( )
        {
            return Math.Pow(Num, 3);
        }

        public double numRaiz( )
        {
            return Math.Sqrt(Num);
        }

        public double numPotencia( )
        {
            return Math.Pow(Num, 10);
        }
    }
}
