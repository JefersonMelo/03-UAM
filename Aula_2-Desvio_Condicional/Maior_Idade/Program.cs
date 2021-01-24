using System;

namespace Maior_Idade
{
    class Program
    {
        /*
         7. Faça um algoritmo que receba a idade de
            uma pessoa e mostre se ela é maior de
            idade ou não.
        */

        static void Main( string[] args )
        {
            Calculos calculos = new Calculos();
            Variaveis variaveis = new Variaveis();

            Console.Write("Sua Idade: ");
            variaveis.NumInt = Console.ReadLine();

            Console.Write(calculos.verificarMaiorIdade(variaveis.NumInt));
        }
    }
}
