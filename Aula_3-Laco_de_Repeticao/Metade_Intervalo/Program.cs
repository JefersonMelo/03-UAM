using System;

namespace Metade_Intervalo
{
    class Program
    {
        /*
        3. Faça um algoritmo que imprima a metade de
        cada número no intervalo de 10 a 20.
        */

        static void Main( string[] args )
        {
            for (int i = 10; i <= 20; i++)
            {
                double div;
                div = (double)i / 2;
                Console.WriteLine(div.ToString("F2"));
            }
        }
    }
}
