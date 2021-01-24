using System;

namespace Area_Triangulo
{
    class Program
    {
        /*Calculo
        * 5. Construir um algoritmo que calcule a área
        de um triângulo retângulo dado a base e a
        altura.
        ( at= (altura*base) / 2 ). 
        */

        static void Main( string[] args )
        {
            Processamento p = new Processamento();
            double baase, altura;
            Console.Write("Entre com a Base: ");
            baase = double.Parse(Console.ReadLine());

            Console.Write("Entre com a Altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Triangulo: " + p.calcularTriangulo(baase, altura));
        }
    }
}
