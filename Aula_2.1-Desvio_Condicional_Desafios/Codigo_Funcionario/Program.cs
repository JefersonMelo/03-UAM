using System;

namespace Codigo_Funcionario
{
    class Program
    {
        /*
         4. Faça um algoritmo que receba o código
            correspondente ao cargo de um funcionário
            e imprima seu cargo e o percentual de
            aumento ao qual este funcionário tem direito
            seguindo a tabela abaixo:
            Código Cargo Percentual
            l Escriturário 50%
            2 Secretário 35%
            3 Caixa 20%
            4 Gerente 10%
            5 Diretor Não tem aumento 
         */

        static void Main( string[] args )
        {
            Variaveis variaveis = new Variaveis();
            Processamento proces = new Processamento();

            Console.Write("Digite o Código Para Cargo: " +
                "\nl Escriturário \n" +
                "2 Secretário \n" +
                "3 Caixa \n" +
                "4 Gerente \n" +
                "5 Diretor \n" + "Código: ");
            variaveis.Num_1_i = int.Parse(Console.ReadLine());
            Console.Write("Entre com o salário: ");
            variaveis.Num_1_d = double.Parse(Console.ReadLine());

            Console.WriteLine(proces.aumentoSalarial(variaveis.Num_1_i, variaveis.Num_1_d));
        }
    }
}
