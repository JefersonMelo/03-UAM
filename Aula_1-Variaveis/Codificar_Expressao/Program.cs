using System;

namespace Codificar_Expressao
{
    class Program
    {
        static void Main( string[] args )
        {

            double respA, respB, respC;
            int A = 10, B = 3, X = 2, Y = 1;

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
            
            //2. Sabendo-se que A=10, B=3, X=2 e Y=1, quais os resultados fornecidos pelas expressões abaixo:
            //a) X+Y-A + (A –B^2+Y) – 4*X
            respA = X + Y - A + (A - Math.Pow(B, 2) + Y) - 4 * X;
            Console.WriteLine("a)" + respA);
            //b) B ^ (2 + X) – A / 3 + 1
            respB = Math.Pow(B, 2 + X) - A / 3 + 1;
            Console.WriteLine("b)" + respB);
            //c) (A –B^3 >X) OR (X – 3 =1)
            respC = A - Math.Pow(B, 3);
            if (respC > X || (X - 1) == 1){Console.WriteLine("c)" + 0);}
            else{Console.WriteLine("cc)" + respC);}
            //d) NOT (X*Y = B)
            if (!(X * Y == B)){Console.WriteLine("d)Não");}
            else{Console.WriteLine("d)Sim");}
        }
    }
}
