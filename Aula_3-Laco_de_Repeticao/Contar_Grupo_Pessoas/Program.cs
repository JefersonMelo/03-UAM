using System;

namespace Contar_Grupo_Pessoas
{
    class Program
    {
        /*
        Exercício 6
        • O algoritmo também deve calcular e mostrar:
        § O número de candidatos do sexo feminino
        § O número de candidatos do sexo masculino
        § A idade média dos homens que já têm
        experiência no serviço
        § A porcentagem dos homens com mais de 45
        anos entre o total dos homens
        § O número de mulheres com idade inferior a 21
        anos e com experiência no serviço
        § A menor idade entre as mulheres que já têm
        experiência no serviço          
        */

        static void Main( string[] args )
        {
            //captura tecla enter  https://docs.microsoft.com/pt-br/dotnet/api/system.console.readkey?view=net-5.0
            //if (Console.ReadKey().Key == ConsoleKey.Enter)
            //{
            //    break;
            //}

            char sexo, experiencia;
            int contF = 0, contM = 0, contIdadeF = 0, idade, contExpF = 0, contExpM = 0, contIdadeM = 0;
            do
            {

                Console.Write("Sexo: ");
                sexo = char.Parse(Console.ReadLine());
                Console.Write("Idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.Write("Experiência: ");
                experiencia = char.Parse(Console.ReadLine());

                //§ O número de candidatos do sexo feminino
                if (sexo == 'f')
                {
                    contF++;
                    // § O número de mulheres com idade inferior a 21 anos e com experiência no serviço
                    if (sexo == 'f' && idade < 21 && experiencia == 's')
                    {
                        contExpF++;
                    }
                    //§ A menor idade entre as mulheres que já têm experiência no serviço
                    else if (sexo == 'f' && idade < 21 && experiencia == 's')
                    {
                        if (idade < 20)
                        {
                            contIdadeF = idade;
                        }
                        else if (idade > 20)
                        {
                            contIdadeF = idade;
                        }

                    }

                }
                //§ O número de candidatos do sexo masculino
                else if (sexo == 'm')
                {
                    contM++;
                    //§ A idade média dos homens que já têm experiência no serviço
                    if (sexo == 'm' && experiencia == 's')
                    {
                        contIdadeM++;
                    }
                    //§ A porcentagem dos homens com mais de 45 anos entre o total dos homens
                    else if (sexo == 'm' && idade > 45 && experiencia == 's')
                    {
                        contExpM++;
                    }

                }

            } while (sexo == ' ');
            Console.WriteLine("O número de candidatos do sexo feminino: " + contF);
            Console.WriteLine("O número de mulheres com idade inferior a 21 anos e com experiência no serviço: " + contExpF);
            Console.WriteLine("A menor idade entre as mulheres que já têm experiência no serviço: " + contIdadeF);
            Console.WriteLine("O número de candidatos do sexo masculino: " + contM);
            Console.WriteLine("A idade média dos homens que já têm experiência no serviço: " + contIdadeM / contM);
            Console.WriteLine("A porcentagem dos homens com mais de 45 anos entre o total dos homens" + ((contExpM / contM) * (1 / 100)) + "%");
        }
    }
}
