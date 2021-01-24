using System;

namespace Imprimir_Crescente
{
    class Program
    {
        /*
        3. Ler um número inteiro maior que 1 e
        imprimir na tela a sequência de números
        que vai do número 1 até o número lido. 
        */

        static void Main( string[] args )
        {
            Console.Write("Num: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 1)
            {
                Console.Write("O Num deve ser maior que 1, ao menos.");
            }
            else if (num > 1)
            {
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
