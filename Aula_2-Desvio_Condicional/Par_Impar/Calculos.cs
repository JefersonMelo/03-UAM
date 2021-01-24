using System;
using System.Collections.Generic;
using System.Text;

namespace Par_Impar
{
    class Calculos
    {
        public string verificarSePar( string _num )
        {
            int num = Convert.ToInt32(_num);

            if ((num % 2) == 0)
            {
                return "Par";
            }
            return "Impar";
        }
    }
}
