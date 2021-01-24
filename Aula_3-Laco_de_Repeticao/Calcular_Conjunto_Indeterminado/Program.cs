using System;

namespace Calcular_Conjunto_Indeterminado
{
    class Program
    {
        /*
        Exercício 4
        • Faça um algoritmo que leia um conjunto
        não determinado de valores e mostre:
        § O valor lido
        § O quadrado
        § O cubo
        § A raiz quadrada
        • Finalize a entrada de dados com um valor
        negativo ou zero.                          
        */

        static void Main( string[] args )
        {
            Variaveis v = new Variaveis();

            do
            {
                Console.Write("Entre com o Valor: ");
                v.Num_1_double = double.Parse(Console.ReadLine());
                //condição de parada
                if (v.Num_1_double == 0) { break; }
                //§ O valor lido
                Console.WriteLine("Valor Digitado: " + v.Num_1_double);
                //§ O quadrado
                Console.WriteLine("O quadrado do Valor: " + Math.Pow(v.Num_1_double, 2));
                //§ O cubo
                Console.WriteLine("O cubo do Valor: " + Math.Pow(v.Num_1_double, 3));
                //§ A raiz quadrada
                Console.WriteLine("A raiz quadrada do Valor: " + Math.Sqrt(v.Num_1_double));

            } while (v.Num_1_double > 1);
        }
    }
}
