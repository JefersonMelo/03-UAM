using System;

namespace Calculos
{
    class Program
    {
        /*
         9. Faça um algoritmo que receba um
            número, calcule e mostre:
            – O número digitado ao quadrado;
            – O número digitado ao cubo;
            – A raiz quadrada do número digitado;
            – O número elevado a potência 10; 

         */
        static void Main( string[] args )
        {
            Processamento p = new Processamento();

            Console.Write("Entre com um Número: ");
            p.Num = double.Parse(Console.ReadLine());
            Console.WriteLine("Quadrado: " + p.numQuadrado());

            Console.WriteLine("Cubo: " + p.numCubo());

            Console.WriteLine("Raíz: " + p.numRaiz());

            Console.WriteLine("Potência: " + p.numPotencia());
        }
    }
}
