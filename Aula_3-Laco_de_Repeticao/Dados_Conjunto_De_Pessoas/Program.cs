using System;

namespace Dados_Conjunto_De_Pessoas
{
    class Program
    {
        /*
            4. Faça um algoritmo que receba a idade, a
            altura e o peso de um conjunto de
            pessoas, calcule e mostre:
            § A quantidade de pessoas com idade superior
            a 50 anos;
            § A média das alturas das pessoas com idade
            entre 10 e 20 anos;
            § A percentagem de pessoas com peso inferior
            a 40 quilos entre todas as pessoas
            analisadas; 
            Como pensar na resolução???
            • Quantas repetições?
            25
            • A quantidade de pessoas com idade superior a 50 anos
            Verificar se a idade > 50 anos, se for incrementa um contador
            (contIdade)
            • A média das alturas das pessoas com idade entre 10 e 20
            anos
            Verificar se a idade >= 10 e <= 20 anos, se for incrementa um
            contador (contAltura) e acumular as alturas (acmAltura)
            • % de pessoas com peso inferior a 40 quilos entre todas as
            pessoas analisadas
            Verificar se o peso é < 40 quilos, se for incrementar um contador
            (contPeso)
            • Ao terminar as repetições
            Calcular a média das alturas e calcular o percentual de acordo
            com o contPeso e total de pessoas (contPeso*100)/25           
            */

        static void Main( string[] args )
        {
            Variaveis v = new Variaveis();
            int contIdadeMaisCinquenta = 0, contIdadeMenosVinte = 0;
            do
            {
                //contagem de pessoas
                v.TotalPessoas++;

                Console.Write("Idade: ");
                v.Num_1_int = int.Parse(Console.ReadLine());
                //verificação para encerramento do programa
                if (v.Num_1_int < 1) { break; }
                Console.Write("\nAltura: ");
                v.Num_1_double = double.Parse(Console.ReadLine());
                Console.Write("\nPeso: ");
                v.Num_2_double = double.Parse(Console.ReadLine());

                //§ A quantidade de pessoas com idade superior a 50 anos;
                if (v.Num_1_int > 50)
                {
                    contIdadeMaisCinquenta++;
                }
                //§ A média das alturas das pessoas com idade entre 10 e 20 anos;
                else if (v.Num_1_int >= 10 || v.Num_1_int <= 20)
                {
                    contIdadeMenosVinte++;
                    v.Soma += v.Num_1_double;
                    v.Media = v.Soma / contIdadeMenosVinte;
                }
                //§ A percentagem de pessoas com peso inferior a 40 quilos entre todas as pessoas
                else if (v.Num_2_double < 40.0)
                {
                    //contador
                    v.Num_2_int++;
                    v.Porcentagem = v.TotalPessoas % v.Num_2_int;
                }
                //soma de todos os quilos
                v.PesoTotal += v.Num_2_double;

                //Calcular a média das alturas e calcular o percentual de acordo com o contPeso e total de pessoas(contPeso*100)/ 25
                if (v.Num_1_int < 1)
                {
                    v.PesoTotal = (v.PesoTotal * 100) / v.TotalPessoas;
                }

            } while (v.Num_1_int > 0);

            Console.Write("\nA quantidade de pessoas com idade superior a 50 anos: " + contIdadeMaisCinquenta);
            Console.Write("\nA média das alturas das pessoas com idade entre 10 e 20 anos: " + v.Media);
            Console.Write("\nA percentagem de pessoas com peso inferior a 40 quilos entre todas as pessoas: " + v.Porcentagem);
            Console.Write("\nCalcular a média das alturas e calcular o percentual de acordo com o contPeso e total de pessoas: " + v.PesoTotal);
        }
    }
}
