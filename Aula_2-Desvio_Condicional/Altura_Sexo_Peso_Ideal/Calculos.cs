using System;
using System.Collections.Generic;
using System.Text;

namespace Altura_Sexo_Peso_Ideal
{
    class Calculos
    {
        public string calcularPesoIdeal( string _altura, char _sexo )
        {
            double altura = Convert.ToDouble(_altura);
            double pesoIdeal;

            if (_sexo.Equals('m') == true || _sexo.Equals('M') == true)
            {
                pesoIdeal = 72.7 * altura - 58;

                return "Masculino: " + pesoIdeal;
            }

            pesoIdeal = 62.1 * altura - 44.7;

            return "Feminino: " + pesoIdeal;

        }
    }
}
