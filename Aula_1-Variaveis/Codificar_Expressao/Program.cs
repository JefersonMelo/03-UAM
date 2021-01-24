using System;

namespace Codificar_Expressao
{
    class Program
    {
        static void Main( string[] args )
        {

            double respA, respB, respC;
            Console.Write("Num: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            //1. Escreva expressões utilizando algoritmos:
            //a)
            respA = 2 * x - Math.Sqrt(y) / 3 + x;
            //b)
            respB = 1 / (4 * y) + Math.Pow(3 * x / 2, 3);
            //c)
            respC = Math.Cbrt(Math.Pow(x, 2)) + 2;
            Console.WriteLine("A)" + respA +
            "\nB)" + respB +
            "\nC)" + respC);

        }
    }
}
