using System;
using System.Collections.Generic;
using System.Text;

namespace Nome_Idade
{
    class Variaveis
    {
        string nome;
        int idade;
        char sexo;

        public Variaveis( ) { }

        public Variaveis( string nome, int idade, char sexo )
        {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public char Sexo { get => sexo; set => sexo = value; }

    }
}
