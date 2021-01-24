using System;

namespace Calcular_Idade_Altura_Conjunto_Pessoas
{
    class Program
    {
        /*
        7. Faça um algoritmo que receba as idades,
        pesos e alturas de um conjunto de
        pessoas, calcule e mostre:
        § A média das idades de todas as pessoas
        § A quantidade de pessoas com peso superior
        a 90kg e altura inferior a 1,50 metro
        § A porcentagem de pessoas com idade entre
        10 e 30 anos entre as pessoas que medem
        mais de 1,90 m 
        */

        static void Main( string[] args )
        {
            Variaveis v = new Variaveis();

            do
            {
                //contador
                v.Cont_1++;

                //idades, pesos e alturas
                Console.Write("\nIdade: ");
                v.Num_1_int = int.Parse(Console.ReadLine());
                //Verificar Encerramento
                if (v.Num_1_int < 1) { break; }
                Console.Write("Peso: ");
                v.Num_1_double = double.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                v.Num_2_double = double.Parse(Console.ReadLine());

                //§ A média das idades de todas as pessoas
                v.Soma += v.Num_1_int;
                v.Media = v.Soma / v.Cont_1;

                //§ A quantidade de pessoas com peso superior a 90kg e altura inferior a 1,50 metro
                if (v.Num_1_double >= 90.0 && v.Num_2_double <= 1.50)
                {
                    v.Cont_2++;
                }
                //§ Número de pessoas com idade entre 10 e 30 anos entre as pessoas que medem mais de 1,90 m
                else if (v.Num_1_int >= 10 || v.Num_1_int <= 30 && v.Num_2_double >= 1.90)
                {
                    //contador
                    v.Num_2_int++;

                }

            } while (v.Num_1_int < 1);

            //§ A porcentagem de pessoas com idade entre 10 e 30 anos entre as pessoas que medem mais de 1,90 m
            v.Porcentagem = ((v.Num_2_int / v.Cont_1) - 1) * 100;

            Console.Write("Qtd Pessoas Peso > 90kg e Altura < 1,50: " + v.Cont_2);
            Console.Write("A porcentagem de pessoas com idade entre 10 e 30 anos " +
                    "entre as pessoas que medem mais de 1,90: " + v.Porcentagem);
        }
    }
}
