using System;
using System.Collections.Generic;
using System.Text;

namespace Calcular_Diferenca_Maior_Menor
{
    class Calculos
    {
       public string compararInteiros( string num, string num_2 )
        {
            int numInt = int.Parse(num);
            int numInt_2 = int.Parse(num_2);

            if (numInt > numInt_2)
            {
                numInt -= numInt_2;
                num = Convert.ToInt32(numInt).ToString();
                return "1º Número Maior. A doferença entre eles é de: " + num;
            }
            else if (numInt < numInt_2)
            {
                numInt_2 -= numInt;
                num_2 = Convert.ToInt32(numInt_2).ToString();
                return "2º Número Maior. A doferença entre eles é de: " + num_2;
            }

            return "Iguais";
        }
    }
}
