using System;

namespace Verificar_Senha
{
    class Program
    {
        /*
        10.Faça um algoritmo que verifique a
        validade de uma senha fornecida pelo
        usuário. Sabendo que a senha é R10p5,
        imprimir mensagem de “acesso concedido” ou “acesso negado”.           
        */

        static void Main( string[] args )
        {
            Calculos calculos = new Calculos();
            Variaveis variaveis = new Variaveis();

            Console.Write("Digite Uma Senha: ");
            variaveis.NumInt = Console.ReadLine();
            Console.Write("Digite novamente: ");
            variaveis.NumInt_2 = Console.ReadLine();

            calculos.compararSenha(variaveis.NumInt, variaveis.NumInt_2);
        }
    }
}
