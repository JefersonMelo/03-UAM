using System;

namespace Contador_Par_Impar
{
    class Program
    {
        /*
        4. Faça um algoritmo que leia 200 números inteiros
        e imprima quantos são pares e quantos são ímpares.
        */

        static void Main( string[] args )
        {
            for (int i = 0; i <= 200; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Par: " + i);
                }
                else if (i % 2 != 0)
                {
                    Console.WriteLine("Impar: " + i);
                }
            }
        }
    }
}
