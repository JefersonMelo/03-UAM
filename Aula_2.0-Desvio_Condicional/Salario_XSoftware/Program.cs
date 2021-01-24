using System;

namespace Salario_XSoftware
{
    class Program
    {
        /*
         6. A empresa XSoftware concedeu um
            bônus de 20% do valor do salário a
            todos os funcionários com tempo de
            trabalho na empresa igual ou superior a
            cinco anos e de 10% aos demais
            funcionários.
            – Faça um algoritmo que leia o salário e a
            quantidade de anos de casa de um
            funcionário, calcule e imprima o valor do
            bônus.            
         */

        static void Main( string[] args )
        {
            Calculos calculos = new Calculos();
            Variaveis variaveis = new Variaveis();

            Console.Write("Tempo na Empresa: ");
            variaveis.NumInt = Console.ReadLine();
            Console.Write("Salário: ");
            variaveis.NumInt_2 = Console.ReadLine();

            Console.Write(calculos.aumentarSalario(variaveis.NumInt, variaveis.NumInt_2));
        }
    }
}
