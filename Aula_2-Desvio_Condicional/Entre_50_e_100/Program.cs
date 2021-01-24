using System;

namespace Entre_50_e_100
{
    class Program
    {
        /*
        3. Faça um algoritmo para ler um número inteiro e
            imprimir o seu valor caso esteja no intervalo entre
            50 e 100 (inclusive).            
        */

        static void Main( string[] args )
        {
            Variaveis variaveis = new Variaveis();

            Console.Write("Dado: ");
            variaveis.NumInt = int.Parse(Console.ReadLine());

            if (variaveis.NumInt > 50 && variaveis.NumInt <= 100)
            {
                Console.Write("Num: " + variaveis.NumInt);
            }
            else
            {
                Console.Write("Não é Maior");
            }
        }
    }
}
