using System;
using System.Collections.Generic;
using System.Text;

namespace Linha_De_Credito_RJ
{
    class Processamento
    {
        //calcular se é possível realizar emprestimo consignado
        public string calcularPrestacao( string num_1, string num_2 )
        {
            double salarioBruto = Convert.ToDouble(num_1);
            double valorPrestacao = Convert.ToDouble(num_2);

            double valorMaximo = salarioBruto * (30.0 / 100.0);

            if (valorMaximo < valorPrestacao)
            {
                return "Empréstimo negado, valor máximo permitido é: " + valorMaximo.ToString("F2");
            }
            return "Empréstimo permitido, valor: " + valorPrestacao.ToString("F2") + " dentro do permitido";
        }
    }
}
