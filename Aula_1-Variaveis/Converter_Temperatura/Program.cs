using System;

namespace Converter_Temperatura
{
    class Program
    {
        /*
         6) Faça um algorimo para transformar um valor de temperatura em ºF para ºC,
            sabendo-se que:C=((F-32)*5)/9    
         */

        static void Main( string[] args )
        {
            double fahrenheit, celcius;
            fahrenheit = double.Parse(Console.ReadLine());
            celcius = (fahrenheit - 32) * 5 / 9;
            Console.Write(celcius.ToString("F2") + "°C");
        }
    }
}
