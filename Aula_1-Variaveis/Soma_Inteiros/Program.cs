using System;

namespace Soma_Inteiros
{
    class Program
    {
        /*
        2. Faça um algoritmo que leia quatro números
            inteiros, calcule e mostre a soma desses
            números.              
        */

        static void Main( string[] args )
        {
            int num;
            int soma = 0;
            Console.Write("Enre com o");

            for (int i = 0; i < 4; i++)
            {
                Console.Write(" " + (i + 1) + "º " + "Número: ");
                num = int.Parse(Console.ReadLine());

                soma += num;

                if (i == 3)
                {
                    Console.WriteLine();
                    Console.Write("Total: " + soma);
                }
            }
        }
    }
}
