using System;
using System.Collections.Generic;
using System.Text;

namespace Calcular_Novo_salario
{
    class Processamento
    {
        public double calcularSalario( double salario )
        {
            salario += salario * 0.25;
            return salario;
        }
    }
}
