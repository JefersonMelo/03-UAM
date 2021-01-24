using System;

namespace Double_Decrescente
{
    class Program
    {
        /*
         5. Ler dois valores double e apresentá-los em ordem
            decrescente. Supor que não sejam iguais. 
        */
        static void Main( string[] args )
        {
            Calculos calculos = new Calculos();
            Variaveis variaveis = new Variaveis();

            Console.Write("1º Num: ");
            variaveis.NumInt = Console.ReadLine();
            Console.Write("2º Num: ");
            variaveis.NumInt_2 = Console.ReadLine();

            Console.Write(calculos.compararDoubles(variaveis.NumInt, variaveis.NumInt_2));
        }
    }
}
