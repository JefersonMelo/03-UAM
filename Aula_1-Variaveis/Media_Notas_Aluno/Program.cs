using System;

namespace Media_Notas_Aluno
{
    class Program
    {
        /*
         3. Faça um algoritmo que leia três notas de um
             aluno, calcule e mostre a média aritmética do
             aluno.             
         */

        static void Main( string[] args )
        {
            double nota, soma = 0;
            Console.Write("Entre com a ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write((i + 1) + "º " + "Nota: ");
                nota = double.Parse(Console.ReadLine());
                soma += nota;
                if (i == 2)
                {
                    nota = soma / 3;
                    Console.WriteLine();
                    Console.Write("Média: " + nota);
                }
            }
        }
    }
}
