using System;

namespace Par_Impar
{
    class Program
    {
        /*
         8. Ler um número inteiro e apresentar uma
            mensagem informando se o número é par
            ou ímpar. (usar o operador módulo (%) )                    
         */

        static void Main( string[] args )
        {
            Calculos calculos = new Calculos();
            Variaveis variaveis = new Variaveis();

            Console.Write("Num: ");
            variaveis.NumInt = Console.ReadLine();

            Console.Write(calculos.verificarSePar(variaveis.NumInt));
        }
    }
}
