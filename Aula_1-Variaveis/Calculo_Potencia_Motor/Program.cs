using System;

namespace Calculo_Potencia_Motor
{
    class Program
    {
        /*
        5) A potência de um motor pode ser expressa em cv ou kW . Sabe-se que
        1kW = 0,736 cv. Faça um algoritmo que leia um valor de potência em cv e
        informe o valor de potência equivalente em kW.
        */

        static void Main( string[] args )
        {
            double kW = 0.736;
            double cv, kwTotal;
            cv = double.Parse(Console.ReadLine());
            kwTotal = cv * kW;
            Console.Write("Resultado: " + kwTotal);
        }
    }
}
