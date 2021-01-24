using System;

namespace Media_Idades
{
    class Program
    {
        /*
        Faça um algoritmo que receba a idade e a
        altura de várias pessoas, calcule e mostre
        a média das alturas daquelas com mais
        de 50 anos.
        § Para encerrar a entrada de dados, digite uma
        idade menor ou igual a zero.        
        */

        static void Main( string[] args )
        {
            double media = 0.0, soma = 0.0, altura;
            int cont = 0, idade;

            do
            {
                Console.Write("Idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade <= 50 && idade > 0)
                {
                    Console.Write("Altura: ");
                    altura = double.Parse(Console.ReadLine());
                    cont++;
                    soma += altura;
                    media = soma / cont;
                }
                else if (idade > 50)
                {
                    Console.Write("Altura: ");
                    altura = double.Parse(Console.ReadLine());
                    cont++;
                    soma += altura;
                    media = soma / cont;
                }
                else
                {
                    break;
                }

            } while (idade > 0);

            Console.Write("Quantidade " + cont + " e média das alturas de pessoas 50 +: " + media.ToString("F2"));
        }
    }
}
