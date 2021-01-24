using System;

namespace Calcular_Diferenca_Maior_Menor
{
    class Program
    {
        /*
         4. Ler dois valores inteiros e apresentar a diferença
            do maior pelo menor. Supor que não sejam iguais.
         */

        static void Main( string[] args )
        {
            Calculos calculos = new Calculos();
            Variaveis variaveis = new Variaveis();

            Console.Write("Num Um: ");
            variaveis.NumInt = Console.ReadLine();
            Console.Write("Num Dois: ");
            variaveis.NumInt_2 = Console.ReadLine();

            Console.WriteLine(calculos.compararInteiros(variaveis.NumInt, variaveis.NumInt_2));
        }
    }
}
