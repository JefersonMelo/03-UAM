using System;

namespace Se_Maior_Tres
{
    class Program
    {
        /*
        2. Faça um algoritmo para ler um número inteiro e
        apresentá-lo, caso não seja maior que três.   
        */

        static void Main( string[] args )
        {
            Variaveis variaveis = new Variaveis();

            Console.Write("Número: ");
            variaveis.NumInt = int.Parse(Console.ReadLine());

            if (variaveis.NumInt > 3)
            {
                Console.Write("É maior: " + variaveis.NumInt);
            }
            else
            {
                Console.Write("Não é Maior que três: " + variaveis.NumInt);
            }
        }
    }
}
