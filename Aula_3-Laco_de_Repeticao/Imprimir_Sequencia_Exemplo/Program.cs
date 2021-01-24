using System;

namespace Imprimir_Sequencia_Exemplo
{
    class Program
    {
        /*
        7.Construir um algoritmo que leia um
        número inteiro e imprimir a sequência: 1,
        2, 4, 8, 16, 32,... enquanto o valor for
        menor ou igual ao valor lido. – Exemplo:
        – Valor lido: 82
        – Sequencia impressa: 1, 2, 4, 8, 16, 32, 64
        */

        static void Main( string[] args )
        {
            Console.Write("Numéro: ");
            int num = int.Parse(Console.ReadLine());
            int anterior = 1, dobro;

            for (int i = 1; i <= num; i++)
            {
                if (i < 2)
                {
                    Console.WriteLine(i + "\n" + (i * 2));
                }

                anterior += anterior;
                dobro = anterior * 2;
                Console.WriteLine(dobro);
                num /= 2;
            }
        }
    }
}
