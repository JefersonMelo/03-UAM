using System;

namespace Nome_Idade
{
    class Program
    {
        /* Variaveis
         1. Faça um algoritmo que leia o nome, a idade e
             o sexo de uma Variaveis. Imprimir todas as
             informações no final.
        */

        static void Main( string[] args )
        {
            Processamento p = new Processamento();
            Variaveis v = new Variaveis();


            Console.Write("Digite Seu Nome: ");
            v.Nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            v.Idade = int.Parse(Console.ReadLine());

            Console.Write("Seu Sexo | M ou F: ");
            v.Sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Nome: " + v.Nome + " Idade: " + v.Idade + " Sexo: " + v.Sexo);
        }
    }
}
