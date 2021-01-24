using System;

namespace Imprimir_Decrescente
{
    class Program
    {
        /*
        1. Faça um algoritmo que imprima a seguinte
        sequência: 100, 99, 98, 97, 96, ... 1                           
        */

        static void Main( string[] args )
        {
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
