using System;

namespace Tabuada_5
{
    class Program
    {
        /*
        6. Faça um algoritmo que imprima a
        tabuada do número 5.
        */

        static void Main( string[] args )
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " x " + "5 = " + (i * 5));
            }
        }
    }
}
