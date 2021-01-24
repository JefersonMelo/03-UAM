using System;
using System.Collections.Generic;
using System.Text;

namespace Calcular_Idade
{
    class Processamento
    {        
        public Processamento( ) { }

        private string anoAtual = DateTime.Now.Year.ToString();
        public string AnoAtual { get => anoAtual; set => anoAtual = value; }

        public int calcularIdade( int ano )
        {
            int idade;
            string anoAtual = AnoAtual;
            idade = int.Parse(anoAtual) - ano;
            return idade;
        }
    }
}
