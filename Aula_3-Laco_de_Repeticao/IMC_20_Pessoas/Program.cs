using System;

namespace IMC_20_Pessoas
{
    class Program
    {
        /*
        8. O IMC (índice de Massa Corporal) é uma
        medida do grau de obesidade de uma
        pessoa.
        § Faça um algoritmo que leia a altura e o peso
        de 20 pessoas. Calcular o IMC de cada
        pessoa e verificar quantas pessoas estão
        com o IMC entre 18,5 e 24,9 que é
        considerado sem obesidade.
        § IMC = peso / altura^2
        */

        static void Main( string[] args )
        {
            Processamentos p = new Processamentos();
            Variaveis v = new Variaveis();

            int qtd, cont = 0;
            Console.Write("Num: ");
            qtd = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtd; i++)
            {
                Console.Write("Peso: ");
                v.Dado_1_double = double.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                v.Dado_2_double = double.Parse(Console.ReadLine());

                if (p.calcularIMC(v.Dado_1_double, v.Dado_2_double) <= 24.9 || p.calcularIMC(v.Dado_1_double, v.Dado_2_double) >= 18.5)
                {
                    cont++;
                    //Console.Write("Qtd Pessoas Não Obesas: " + cont );
                }
                else if (p.calcularIMC(v.Dado_1_double, v.Dado_2_double) < 18.5)
                {
                    cont++;
                    Console.Write("Qtd Desnutridas: " + cont);
                }
            }
            Console.Write("Qtd Não Obesas: " + cont);
        }
    }
}
