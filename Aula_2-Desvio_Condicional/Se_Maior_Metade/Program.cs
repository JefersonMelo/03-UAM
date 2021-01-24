using System;

namespace Se_Maior_Metade
{
    class Program
    {
        /*
         1. Faça um algoritmo que leia um número inteiro e
            se ele for maior que 20, imprimir a sua metade.
         */

        static void Main( string[] args )
        {
            Calculos calculos = new Calculos();
            Variaveis variaveis = new Variaveis();

            Console.Write("Entre com um número: ");
            variaveis.NumInt = int.Parse(Console.ReadLine());

            if (variaveis.NumInt > 20)
            {
                Console.WriteLine("Metade: " + calculos.retornarMetade(variaveis.NumInt));
            }
            else
            {
                Console.Write("Inteiro: " + variaveis.NumInt);
            }
        }
    }
}
