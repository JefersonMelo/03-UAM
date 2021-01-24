using System;
using System.Collections.Generic;
using System.Text;

namespace Calcular_Notas_Conjunto_Alunos
{
    class Variaveis
    {
        //inteiros
        private int num_1_int;
        private int num_2_int;
        private int cont_1;
        private int cont_2;
        private int totalPessoas;
        //ponto flutuante
        private double num_1_double;
        private double num_2_double;
        private double media;
        private double soma;
        private double soma_2;
        private double porcentagem;
        private double pesoTotal;
        //texto
        private string dado_1_string;
        private string dado_2_string;
        //caracter
        private char dado_1_char;
        private char dado_2_char;
        //data
        private DateTime data;

        public int Num_1_int { get => num_1_int; set => num_1_int = value; }
        public int Num_2_int { get => num_2_int; set => num_2_int = value; }
        public int Cont_1 { get => cont_1; set => cont_1 = value; }
        public int Cont_2 { get => cont_2; set => cont_2 = value; }
        public int TotalPessoas { get => totalPessoas; set => totalPessoas = value; }

        public double Num_1_double { get => num_1_double; set => num_1_double = value; }
        public double Num_2_double { get => num_2_double; set => num_2_double = value; }
        public double Media { get => media; set => media = value; }
        public double Soma { get => soma; set => soma = value; }
        public double Porcentagem { get => porcentagem; set => porcentagem = value; }
        public double PesoTotal { get => pesoTotal; set => pesoTotal = value; }
        public double Soma_2 { get => soma_2; set => soma_2 = value; }

        public string Dado_1_string { get => dado_1_string; set => dado_1_string = value; }
        public string Dado_2_string { get => dado_2_string; set => dado_2_string = value; }

        public char Dado_1_char { get => dado_1_char; set => dado_1_char = value; }
        public char Dado_2_char { get => dado_2_char; set => dado_2_char = value; }

        public DateTime Data { get => data; set => data = value; }

    }
}
