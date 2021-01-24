using System;
using System.Collections.Generic;
using System.Text;

namespace Valor_Conta_Luz
{
    class Processamento
    {
        public Processamento( ) { }

        private int qtdWatt;
        private double valorUnidadeWatt;
        private double salarioMinimo;
        private double num;

        public int QtdWatt { get => qtdWatt; set => qtdWatt = value; }
        public double ValorUnidadeWatt { get => valorUnidadeWatt; set => valorUnidadeWatt = value; }
        public double SalarioMinimo { get => salarioMinimo; set => salarioMinimo = value; }
        public double Num { get => num; set => num = value; }

        public double calcularQuilowatt( double salarioMinimo )
        {
            salarioMinimo = SalarioMinimo;
            valorUnidadeWatt = (SalarioMinimo / 500);
            return valorUnidadeWatt;
        }

        public double calcularContaEletrica( int qtdWatt )
        {
            qtdWatt = QtdWatt;
            double valorConta = valorUnidadeWatt * qtdWatt;
            return valorConta;
        }
    }
}
