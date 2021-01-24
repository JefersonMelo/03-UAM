using System;

namespace Imprimir_Quadrado_15_a_100
{
    class Program
    {
        /*
        2. Faça um algoritmo que apresente na tela os
        quadrados dos números inteiros entre 15 e 100
        O quadrado de 15 é 225
        O quadrado de 16 é 256
        .....
        O quadrado de 99 é 9801
        O quadrado de 100 é 10000 
        */

        static void Main( string[] args )
        {
            for (int i = 15; i <= 100; i++)
            {
                Console.WriteLine("O quadrado de " + i +
                " = " + Math.Pow(i, 2));
            }
        }
    }
}
