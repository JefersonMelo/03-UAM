using System;

namespace Categoria_Nadador
{
    class Program
    {
        /*
         3. Faça um algoritmo que receba a idade de
            um nadador e imprima a sua categoria
            seguindo as regras:
            Categoria Idade
            Infantil A 5 - 7 anos
            Infantil B 8 - 10 anos
            Juvenil A 11- 13 anos
            Juvenil B 14- 17 anos
            Sênior maiores de 18 anos
         */

        static void Main( string[] args )
        {
            Variaveis variaveis = new Variaveis();
            Processamento proces = new Processamento();

            Console.Write("Entre com a Idade: ");
            variaveis.Num_1_i = int.Parse(Console.ReadLine());

            Console.WriteLine(proces.categoriaNadador(variaveis.Num_1_i));
        }
    }
}
