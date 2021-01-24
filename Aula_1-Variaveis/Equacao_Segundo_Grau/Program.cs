using System;

namespace Equacao_Segundo_Grau
{
    class Program
    {
        /*
        3) Faça um algoritmo que leia os coeficientes a, b e c referentes a equação do 
        segundo grau(ax^2 +bx + c) e exiba como resultado as raízes da equação.
        */

        static void Main( string[] args )
        {
            double a, x, b, c, result;
            a = double.Parse(Console.ReadLine());
            x = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            result = a * Math.Pow(x, 2) + b * x + c;
            Console.Write("Resultado: " + result);
        }
    }
}
