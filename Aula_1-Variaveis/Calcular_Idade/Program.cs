using System;

namespace Calcular_Idade
{
    class Program
    {
        /*Calculo
         7. Construir um algoritmo que leia o ano de
            nascimento de uma pessoa e o ano atual,
            calcule e mostre:
            – A idade dessa pessoa;
            – Quantos anos essa pessoa terá em 2025   
         */

        static void Main( string[] args )
        {
            Processamento p = new Processamento();

            Console.Write("Ano de Nascimento: ");
            int nascimento = int.Parse(Console.ReadLine());

            Console.Write("Ano Atual: " + p.AnoAtual +
                "\nNascimento: " + nascimento +
                "\nIdade: " + p.calcularIdade(nascimento) + " Anos" +
                "\nIdade em 2025: " + (p.calcularIdade(nascimento) + 5) + " Anos" +
                "\n");
        }
    }
}
