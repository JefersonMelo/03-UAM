using System;

namespace Calcular_Novo_salario
{
    class Program
    {
        /*Calculo
        4. Faça um algoritmo que leia o salário de um
        funcionário. Sabendo que o salário do
        funcionário teve um aumento de 25%, calcular
        e mostrar o novo salário. 
        */
        static void Main( string[] args )
        {
            Processamento p = new Processamento();
            double salario;
            Console.Write("Entre com o Salário: ");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Novo Salário: " + p.calcularSalario(salario));
        }
    }
}
