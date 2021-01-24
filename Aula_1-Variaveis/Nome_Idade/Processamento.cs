using System;
using System.Collections.Generic;
using System.Text;

namespace Nome_Idade
{
    class Processamento
    {
        private int a, b, c, d;
        private int qtdWatt;
        private double valorUnidadeWatt;
        private double salarioMinimo;
        private double num;
        private string anoAtual = DateTime.Now.Year.ToString();



        public Processamento( ) { }

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }
        public int D { get => d; set => d = value; }
        public int QtdWatt { get => qtdWatt; set => qtdWatt = value; }
        public double ValorUnidadeWatt { get => valorUnidadeWatt; set => valorUnidadeWatt = value; }
        public double SalarioMinimo { get => salarioMinimo; set => salarioMinimo = value; }
        public string AnoAtual { get => anoAtual; set => anoAtual = value; }
        public double Num { get => num; set => num = value; }

        public int somar( )
        {
            int soma;
            soma = A + B + C + D;
            return soma;
        }

        public double media( )
        {
            double a, b, c;
            double media;

            a = double.Parse(A.ToString());
            b = double.Parse(B.ToString());
            c = double.Parse(C.ToString());

            media = (a + b + c) / 3;

            return media;
        }

        public double calcularSalario( double salario )
        {

            salario += salario * 0.25;

            return salario;

        }

        public double calcularTriangulo( double baase, double altura )
        {
            double area;
            area = (baase * altura) / 2;
            return area;
        }

        public int calcularIdade( int ano )
        {
            int idade = 0;
            string anoAtual = AnoAtual;

            idade = int.Parse(anoAtual) - ano;

            return idade;
        }

        public double calcularQuilowatt( double salarioMinimo )
        {
            salarioMinimo = SalarioMinimo;
            //qtdWatt = QtdWatt;
            valorUnidadeWatt = (SalarioMinimo / 500);

            return valorUnidadeWatt;
        }

        public double calcularContaEletrica( int qtdWatt )
        {
            qtdWatt = QtdWatt;

            double valorConta = valorUnidadeWatt * qtdWatt;

            return valorConta;
        }

        public double numQuadrado( )
        {
            return Math.Pow(Num, 2);
        }

        public double numCubo( )
        {
            return Math.Pow(Num, 3);
        }

        public double numRaiz( )
        {
            return Math.Sqrt(Num);
        }

        public double numPotencia( )
        {
            return Math.Pow(Num, 10);
        }

        //Para não esquecer... Ruim de trampo
        public override string ToString( )
        {
            return "Para não esquecer... Ruim de trampo";
        }
    }
}
