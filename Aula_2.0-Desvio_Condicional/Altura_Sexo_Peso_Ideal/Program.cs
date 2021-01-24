using System;

namespace Altura_Sexo_Peso_Ideal
{
    class Program
    {
        /*
        9. Faça um algoritmo que leia a altura e o
           sexo de uma pessoa, calcule e mostre seu
           peso ideal. Sabendo que:
           – Para homens: (72,7 * altura) – 58
           – Para mulheres (62,1 * altura) – 44,7           
        */

        static void Main( string[] args )
        {
            Calculos calculos = new Calculos();
            Variaveis variaveis = new Variaveis();

            Console.Write("Sua Altura: ");
            variaveis.NumInt = Console.ReadLine();
            Console.Write("Entre com Sexo: ");
            variaveis.Sexo = char.Parse(Console.ReadLine());

            Console.WriteLine(calculos.calcularPesoIdeal(variaveis.NumInt, variaveis.Sexo));
        }
    }
}
