using System;

namespace Linha_De_Credito_RJ
{
    class Program
    {
        /*
        1.A prefeitura do Rio de Janeiro abriu
           uma linha de crédito para os
           funcionários estatutários. O valor
           máximo da prestação não poderá
           ultrapassar 30% do salário bruto.
           – Faça um algoritmo que leia o salário
           bruto e o valor da prestação, informando
           se o empréstimo pode ou não ser
           concedido.             
        */

        static void Main( string[] args )
        {
            Variaveis variaveis = new Variaveis();
            Processamento proces = new Processamento();

            Console.Write("Entre com o Salário: ");
            variaveis.Num_1_s = Console.ReadLine();
            Console.Write("Entre com a Prestação: ");
            variaveis.Num_2_s = Console.ReadLine();

            Console.WriteLine(proces.calcularPrestacao(variaveis.Num_1_s, variaveis.Num_2_s));
        }
    }
}
