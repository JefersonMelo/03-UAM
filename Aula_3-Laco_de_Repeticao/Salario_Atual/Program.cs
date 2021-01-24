using System;

namespace Salario_Atual
{
    class Program
    {
        /*
        Exercício 2
        • Um funcionário de uma empresa recebe,
        anualmente, aumento salarial. Sabe-se que:
        § Esse funcionário foi contratado em 2005, com
        salário inicial de R$ 1.000,00
        § Em 2006, ele recebeu aumento de 1,5% sobre o
        seu salário inicial
        § A partir de 2007 (inclusive), os aumentos salariais
        sempre corresponderam ao dobro do percentual
        do ano anterior
        • Faça um programa que determine o salário
        atual desse funcionário.                           
        */

        static void Main( string[] args )
        {
            Variaveis v = new Variaveis();

            int anoAtual, anoContrato = 2005;
            v.Porcentagem = 1.5 / 100.0;
            double salario = 1000.0, salarioAtual;
            Console.Write("Ano Atual: ");
            anoAtual = int.Parse(Console.ReadLine());
            anoContrato = anoAtual - anoContrato;

            for (int i = 1; i <= anoContrato; i++)
            {
                v.Porcentagem = v.Porcentagem * 2;
            }
            salarioAtual = salario * v.Porcentagem + salario;

            Console.Write("P: " + v.Porcentagem);
            Console.Write("\nS: " + salarioAtual.ToString("C"));
        }
    }
}
