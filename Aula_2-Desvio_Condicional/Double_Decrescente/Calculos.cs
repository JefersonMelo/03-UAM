using System;
using System.Collections.Generic;
using System.Text;

namespace Double_Decrescente
{
    class Calculos
    {
        public string compararDoubles( string num, string num_2 )
        {
            double numDouble = double.Parse(num);
            double numDouble_2 = double.Parse(num_2);

            if (numDouble > numDouble_2)
            {
                //num = Convert.ToDouble(numDouble).ToString();
                return num + ", " + num_2;
            }
            else if (numDouble < numDouble_2)
            {
                return num_2 + ", " + num;
            }

            return "Iguais";
        }
    }
}
