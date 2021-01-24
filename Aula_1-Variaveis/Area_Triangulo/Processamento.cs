using System;
using System.Collections.Generic;
using System.Text;

namespace Area_Triangulo
{
    class Processamento
    {
        public double calcularTriangulo( double baase, double altura )
        {
            double area;
            area = (baase * altura) / 2;
            return area;
        }
    }
}
