using System;
using System.Collections.Generic;
using System.Text;

namespace Operacoes_Matematicas
{
    class Processamento
    {
        //calculadora básica
        public string calculadora( char sinal, string num_1, string num_2 )
        {
            int num1 = Convert.ToInt32(num_1);
            int num2 = Convert.ToInt32(num_2);

            if (sinal == '+')
            {
                int soma = num1 + num2;
                return "Soma: " + soma;
            }
            if (sinal == '-')
            {
                int subtracao = num1 - num2;
                return "Subtração: " + subtracao;
            }
            if (sinal == '*')
            {
                if (num1 == 0 || num2 == 0)
                {
                    return "Por Zero, sempre Zero";
                }
                else
                {
                    double multiplicacao = (double)num1 * num2;
                    return "Multiplicação: " + multiplicacao;
                }

            }
            if (sinal == '/')
            {
                if (num1 == 0 || num2 == 0)
                {
                    return "Por Zero, sempre Zero";
                }
                else
                {
                    double divisao = (double)num1 / num2;
                    return "Divisão: " + divisao;
                }

            }
            if (sinal == '%')
            {
                if (num1 == 0 || num2 == 0)
                {
                    return "Por Zero, sempre Zero";
                }
                else
                {
                    double resto = (double)num1 % num2;
                    return "Subtração: " + resto;
                }

            }

            return "Sinal Inválido: | " + sinal + " | Use um dos sinais: | + | - | * | / | % |";
        }
    }
}
