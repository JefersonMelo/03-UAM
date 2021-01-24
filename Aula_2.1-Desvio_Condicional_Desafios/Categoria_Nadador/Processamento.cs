using System;
using System.Collections.Generic;
using System.Text;

namespace Categoria_Nadador
{
    class Processamento
    {
        //verificar categoria do nadados
        public string categoriaNadador( int idade )
        {
            if (idade > 5 && idade <= 7)
            {
                return "Infantil A";
            }
            else if (idade > 7 && idade <= 10)
            {
                return "Infantil B";
            }
            else if (idade > 10 && idade <= 13)
            {
                return "Juvenil A";
            }
            else if (idade > 13 && idade <= 17)
            {
                return "Juvenil B";
            }
            else if (idade >= 18)
            {
                return "Senior";
            }
            return "Não Categorizado";
        }
    }
}
