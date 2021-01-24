using System;
using System.Collections.Generic;
using System.Text;

namespace Dados_Conjunto_De_Pessoas
{
    class Variaveis
    {
        //inteiros
        private int num_1_int;
        private int num_2_int;
        private int totalPessoas;
        //ponto flutuante
        private double num_1_double;
        private double num_2_double;
        private double media;
        private double soma;
        private double porcentagem;
        private double pesoTotal;

        public int Num_1_int { get => num_1_int; set => num_1_int = value; }
        public int Num_2_int { get => num_2_int; set => num_2_int = value; }
        public int TotalPessoas { get => totalPessoas; set => totalPessoas = value; }

        public double Num_1_double { get => num_1_double; set => num_1_double = value; }
        public double Num_2_double { get => num_2_double; set => num_2_double = value; }
        public double Media { get => media; set => media = value; }
        public double Soma { get => soma; set => soma = value; }
        public double Porcentagem { get => porcentagem; set => porcentagem = value; }
        public double PesoTotal { get => pesoTotal; set => pesoTotal = value; }
    }
}
