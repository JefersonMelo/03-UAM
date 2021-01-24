using System;

namespace Imprimir_Maior
{
    class Program
    {
        /*
        5. Faça um algoritmo que leia dez números inteiros
        e imprima o maior número da lista.
        */

        static void Main( string[] args )
        {
            int maior = 0, menor = 0, num;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Num " + i + ": ");
                num = int.Parse(Console.ReadLine());

                if (num > maior)
                {
                    maior = num;
                }
                else //if (num < menor)
                {
                    menor = num;
                }
            }
            Console.Write("Maior: " + maior + "\n");
            Console.Write("Menor: " + menor);
        }
    }
}
