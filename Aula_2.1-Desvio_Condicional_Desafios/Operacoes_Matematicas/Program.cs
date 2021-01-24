using System;

namespace Operacoes_Matematicas
{
    class Program
    {
        /*
        2. Faça um algoritmo para realizar as
            operações matemáticas de soma,
            subtração, divisão, multiplicação e resto.
            § O algoritmo deve ler dois números e o sinal
            correspondente à operação desejada (usar char),
            no final deve ser impresso o resultado.
            § Restrições:
            Ø Se o sinal digitado não corresponder a uma operação
            apresentar mensagem “Sinal Inválido” e finalizar
            Ø Para as operações de divisão e resto da divisão
            verificar se o divisor é válido (maior que zero)! 
        */

        static void Main( string[] args )
        {
            Variaveis variaveis = new Variaveis();
            Processamento proces = new Processamento();

            Console.Write("Entre coma operação: ");
            variaveis.Caracter = char.Parse(Console.ReadLine());
            Console.Write("1º Valor: ");
            variaveis.Num_1_s = Console.ReadLine();
            Console.Write("2º Valor: ");
            variaveis.Num_2_s = Console.ReadLine();

            Console.WriteLine(proces.calculadora(variaveis.Caracter, variaveis.Num_1_s, variaveis.Num_2_s));
        }
    }
}
