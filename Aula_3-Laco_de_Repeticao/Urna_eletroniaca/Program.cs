using System;

namespace Urna_eletroniaca
{
    class Program
    {
        /*
        Desafio – Urna Eletrônica
        Códigos	 Tipo	de	Voto	
        1,	2,	3	ou	4	 Voto	para	o	respec0vo	candidato	
        5	 Voto	nulo	
        6	 Voto	em	branco	
        • Em uma eleição presidencial, existem
        quatro candidatos. Os votos são
        informados através de um código
        conforme segue: 
        Desafio – Urna Eletrônica
        • Faça um algoritmo para ler a opção de
        voto de 50 eleitores. Calcular e mostrar:
        § O total de votos para cada candidato;
        § O total de votos nulos;
        § O total de votos em branco;
        § O percentual dos votos branco e nulos sobre
        o total de votos computados.                        
        */

        static void Main( string[] args )
        {

            double candidato_1 = 0, candidato_2 = 0, candidato_3 = 0,
                    candidato_4 = 0, nulo = 0, branco = 0, sair;
            double somaBrancoNulo, percent, somaVotos;
            Console.Write("Escolha Um: " +
                "\ncandidato_1 = 1" +
                "\ncandidato_2 = 2" +
                "\ncandidato_3 = 3" +
                "\ncandidato_4 = 4" +
                "\nNulo = 5" +
                "\nBranco = 6" +
                "\nCandidato: ");
            sair = double.Parse(Console.ReadLine());

            while (sair != 0)
            {
                switch (sair)
                {
                    case 1:
                        candidato_1++;
                        break;
                    case 2:
                        candidato_2++;
                        break;
                    case 3:
                        candidato_3++;
                        break;
                    case 4:
                        candidato_4++;
                        break;
                    case 5:
                        nulo++;
                        break;
                    case 6:
                        branco++;
                        break;
                    default:
                        Console.Write("Candidato Escolhido Inelegível. Escolha um disponível: " +
                            "\ncandidato_1 = 1" +
                            "\ncandidato_2 = 2" +
                            "\ncandidato_3 = 3" +
                            "\ncandidato_4 = 4" +
                            "\nNulo = 5" +
                            "\nBranco = 6" +
                            "\nCandidato: ");
                        break;
                }
                Console.Write("\n******************************");
                Console.Write("Escolha Um: " +
                    "\ncandidato_1 = 1" +
                    "\ncandidato_2 = 2" +
                    "\ncandidato_3 = 3" +
                    "\ncandidato_4 = 4" +
                    "\nNulo = 5" +
                    "\nBranco = 6" +
                    "\nCandidato: ");
                sair = int.Parse(Console.ReadLine());
            }
            Console.Write("\n##############################");
            Console.Write("Candidato 1: " + candidato_1 + "\n");
            Console.Write("Candidato 2: " + candidato_2 + "\n");
            Console.Write("Candidato 3: " + candidato_3 + "\n");
            Console.Write("Candidato 4: " + candidato_4 + "\n");
            Console.Write("Nulos: " + nulo + "\n");
            Console.WriteLine("Brancos: " + branco);
            somaBrancoNulo = nulo + branco;
            somaVotos = candidato_1 + candidato_2 + candidato_3 + candidato_4;
            percent = (somaBrancoNulo / somaVotos) * 100;
            if (somaBrancoNulo >= somaVotos)
            {
                Console.WriteLine("Novas Eleições Serão Necessárias");
            }
            else
            {
                Console.WriteLine("Percentual de Brancos e Nulos: " + percent);
            }
        }
    }
}
