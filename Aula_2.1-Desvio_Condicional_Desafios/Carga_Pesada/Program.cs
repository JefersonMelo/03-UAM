using System;

namespace Carga_Pesada
{
    class Program
    {
        /*
        5. Carga Pesada
            • Construir um algoritmo que receba:
            § O código do estado de origem da carga de um caminhão;
            § O peso da carga do caminhão em toneladas e;
            § O código da carga.
            § Restrição: Validar as entradas código do estado e código da carga!!
            Código	Estado	 IMPOSTO	
            PR	    Paraná       35%	
            RS	    Rio G. Sul   25%	
            RJ	    Rio De Jan   15%	
            ES	    Espírito S   5%	
            SP	    São Paulo    ISENTO	
            CÓDIGO DA CARGA	    PESO T     PREÇO POR QUILO	
                    C         10 a 20	    R$ 100	
                    B         21 a 30       R$ 250	
                    A         31 a 40       R$ 340	
            Desafio 01: Carga Pesada
            • Calcular e mostrar:
            § O peso da carga do caminhão convertido em quilos
            § O preço da carga do caminhão
            § O valor do imposto, sabendo-se que o
            imposto é cobrado sobre o preço da carga do
            caminhão e depende do estado de origem
            § O valor total transportado pelo caminhão
            (preço da carga + impostos)
        */

        static void Main( string[] args )
        {
            Variaveis variaveis = new Variaveis();
            Processamento proces = new Processamento();

            Console.Write("Estado: ");
            variaveis.Num_1_s = Console.ReadLine();
            Console.Write("Entre com o Peso em Toneladas: ");
            variaveis.Num_1_i = int.Parse(Console.ReadLine());
            Console.Write("Entre com a Categoria, sendo A, B ou C: ");
            variaveis.Num_2_s = Console.ReadLine();

            Console.Write("Valor do Imposto Por Estado: " + proces.valorImpostoPorEstado(variaveis.Num_1_s, variaveis.Num_1_i, variaveis.Num_2_s) + "\n");
            Console.Write("Peso Convertido de Tonelada Para Quilos: " + proces.converterToneladaQuilo(variaveis.Num_1_i) + "\n");
            Console.Write("Valor do Frete Sem Imposto do Estado: " + proces.valorFreteSemImpostoEstado(variaveis.Num_1_i, variaveis.Num_2_s).ToString("C") + "\n");
            Console.Write("Valor do Frete Com Imposto do Estado: " + proces.valorTotalFreteComImpostoEstado(variaveis.Num_1_i, variaveis.Num_1_s, variaveis.Num_2_s).ToString("C") + "\n");
        }
    }
}
