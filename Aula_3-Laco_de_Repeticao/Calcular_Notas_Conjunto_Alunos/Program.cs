using System;

namespace Calcular_Notas_Conjunto_Alunos
{
    class Program
    {
        /*
        5. Faça um algoritmo que receba duas notas
        de um conjunto de alunos, calcule e mostre:
        § A média aritmética das duas notas de cada aluno;
        § A mensagem da tabela a seguir:
        § O total de alunos aprovados;
        § O total de alunos de exame;
        § O total de alunos reprovados;
        § A média da classe;
        Exercícios
        MÉDIA ARITMÉTICA MENSAGEM
        ATÉ 3 REPROVADO
        Acima de 3 e Menor que 7 EXAME
        DE 7 PARA CIMA APROVADO 
        */
        //
        static void Main( string[] args )
        {
            Variaveis v = new Variaveis();

            do
            {
                //contador § O total de alunos de exame;
                v.Num_1_int++;

                Console.Write("1º Nota do aluno " + v.Num_1_int + ": ");
                v.Num_1_double = double.Parse(Console.ReadLine());
                Console.Write("2º Nota: ");
                v.Num_2_double = double.Parse(Console.ReadLine());

                //§ A média aritmética das duas notas de cada aluno;
                v.Media = (v.Num_1_double + v.Num_2_double) / 2;
                Console.WriteLine("Média das notas do " + v.Num_1_int + "º aluno: " + v.Media);

                //§ A média da classe;
                v.Soma += v.Num_1_double + v.Num_2_double;

                //§ O total de alunos aprovados;
                if (v.Media >= 7)
                {
                    v.Cont_1++;
                    Console.WriteLine("Aprovado");
                }
                // § O total de alunos reprovados;
                else if (v.Media < 7)
                {
                    v.Cont_2++;

                    if (v.Media < 3)
                    {
                        Console.WriteLine("Reprovado");
                    }

                    Console.WriteLine("Fazer novo Exame");
                }

            } while (v.Num_1_double > 0 || v.Num_2_double > 0);

            Console.Write("O total de alunos aprovados: " + v.Cont_1);
            Console.Write("\nO total de alunos de exame" + v.Num_1_int++);
            Console.Write("\nA média da classe: " + v.Soma / v.Num_1_int);
            Console.Write("\nO total de alunos reprovados : " + v.Cont_2);


        }
    }
}
