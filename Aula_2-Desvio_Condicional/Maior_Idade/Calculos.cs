using System;
using System.Collections.Generic;
using System.Text;

namespace Maior_Idade
{
    class Calculos
    {
        public string verificarMaiorIdade( string _idade )
        {
            int idade = Convert.ToInt32(_idade);

            if (idade >= 18)
            {
                return "Bebe Pinga";
            }
            return "Bebe Leite";
        }
    }
}
