using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo_Funcionario
{
    class Processamento
    {
        //calcular salário
        public string aumentoSalarial( int codCargo, double salario )
        {
            switch (codCargo)
            {
                case 1:
                    salario += salario * (50.0 / 100.0);
                    return "Escriturário 50% de aumento. Novo salário: " + salario;

                case 2:
                    salario += salario * (35.0 / 100.0);
                    return "Secretário 35 % de aumento. Novo salário: " + salario;

                case 3:
                    salario += salario * (20.0 / 100.0);
                    return "Caixa 20% de aumento. Novo salário: " + salario;

                case 4:
                    salario += salario * (10.0 / 100.0);
                    return "Gerente 10% de aumento. Novo salário: " + salario;

                case 5:
                    return "5 Diretor Não tem aumento: " + salario;

            }

            return "Código Inválido";

        }
    }
}
