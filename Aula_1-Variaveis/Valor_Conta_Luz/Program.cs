using System;

namespace Valor_Conta_Luz
{
    class Program
    {
        /*Calculo
            8. Sabe-se que um quilowatt de energia
            custa 1/500 avos do salário mínimo.
            Faça um algoritmo que receba o valor
            do salário mínimo e a quantidade de
            quilowatts consumida por uma
            residência. Calcule e mostre:
            A. O valor, em reais, de cada quilowatt;
            B. O valor, em reais, a ser pago por essa residência 
        */

        static void Main( string[] args )
        {
            Processamento p = new Processamento();

            Console.Write("Salário Mínimo Vingente: ");
            p.SalarioMinimo = double.Parse(Console.ReadLine());
            Console.Write("Entre com a Quantidade de QuiloWatts Gasta: ");
            p.QtdWatt = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor Unidade Quilowatt: " + p.calcularQuilowatt(p.SalarioMinimo));
            Console.WriteLine("Valor da Conta de Luz: " + p.calcularContaEletrica(p.QtdWatt));

            double valorDesconto = p.calcularContaEletrica(p.QtdWatt) - p.calcularContaEletrica(p.QtdWatt) * 0.15;
            Console.WriteLine("15% de Desconto: " + valorDesconto);
        }
    }
}
