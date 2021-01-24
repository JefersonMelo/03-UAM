using System;

namespace Descobrir_Animal
{
    class Program
    {
        /*
        6. Descubra qual é o Animal
        • Construir um algoritmo que seja capaz de
        concluir qual dentre os seguintes animais
        foi escolhido, através de perguntas e
        respostas.
        § Animais possíveis: leão, cavalo, homem,
        macaco, morcego, baleia, avestruz, pinguim,
        pato, águia, tartaruga, crocodilo e cobra.            
        */

        static void Main( string[] args )
        {
            Variaveis variaveis = new Variaveis();

            Console.WriteLine("Qual a Categoria do Pet:\n0 = Para Sair: \n1 = Mamífero: \n2 = Ave: \n3 = Réptil: ");
            variaveis.Num_1_i = int.Parse(Console.ReadLine());

            while (variaveis.Num_1_i > 0)
            {
                //Mamífero
                if (variaveis.Num_1_i == 1)
                {
                    Console.WriteLine("Qual a Categoria do Pet: \n1 = Quadrúpedes: \n2 = Bípedes: \n3 = Voadores: \n4 = Aquáticos: ");
                    variaveis.Num_1_i = int.Parse(Console.ReadLine());
                    //Quadrúpedes
                    if (variaveis.Num_1_i == 1)
                    {
                        Console.WriteLine("Qual a Categoria do Pet: \n1 = Carnívoros: \n2 = Herbívoros: ");
                        variaveis.Num_1_i = int.Parse(Console.ReadLine());
                        //Carnívoros
                        if (variaveis.Num_1_i == 1)
                        {
                            Console.Write("Leão\n");
                        }
                        //Herbívoros
                        else if (variaveis.Num_1_i == 2)
                        {
                            Console.Write("Cavalo\n");
                        }

                    }
                    //Bípedes
                    else if (variaveis.Num_1_i == 2)
                    {
                        Console.WriteLine("Qual a Categoria do Pet: \n1 = Onívoros: \n2 = Frutívoros: ");
                        variaveis.Num_1_i = int.Parse(Console.ReadLine());
                        //Onívoros
                        if (variaveis.Num_1_i == 1)
                        {
                            Console.Write("Homem\n");
                        }
                        //Frutívoros
                        else if (variaveis.Num_1_i == 2)
                        {
                            Console.Write("Macaco\n");
                        }

                    }
                    //Voadores
                    else if (variaveis.Num_1_i == 3)
                    {
                        Console.Write("Morcego\n");
                    }
                    //Aquáticos
                    else if (variaveis.Num_1_i == 4)
                    {
                        Console.Write("Baleira\n");
                    }

                }

                //Ave
                else if (variaveis.Num_1_i == 2)
                {
                    Console.WriteLine("Qual a Categoria do Pet: \n1 = Não-voadoras: \n2 = Nadadoras: \n3 = De rapina: ");
                    variaveis.Num_1_i = int.Parse(Console.ReadLine());
                    //Não-voadoras
                    if (variaveis.Num_1_i == 1)
                    {
                        Console.WriteLine("Qual a Categoria do Pet: \n1 = Tropicais: \n2 = Polares: ");
                        variaveis.Num_1_i = int.Parse(Console.ReadLine());
                        //Tropicais
                        if (variaveis.Num_1_i == 1)
                        {
                            Console.Write("Avestruz\n");
                        }
                        //Polares
                        else if (variaveis.Num_1_i == 2)
                        {
                            Console.Write("Pinguim\n");
                        }
                    }
                    //Nadadoras
                    else if (variaveis.Num_1_i == 2)
                    {
                        Console.Write("Pato\n");
                    }
                    //De rapina
                    else if (variaveis.Num_1_i == 3)
                    {
                        Console.Write("Águia\n");
                    }
                }

                //Réptil
                else if (variaveis.Num_1_i == 3)
                {
                    Console.WriteLine("Qual a Categoria do Pet: \n1 = Com casco: \n2 = Carnívoros: \n3 = Sem patas: ");
                    variaveis.Num_1_i = int.Parse(Console.ReadLine());
                    //Com casco
                    if (variaveis.Num_1_i == 1)
                    {
                        Console.Write("Tartaruga\n");
                    }
                    //Carnívoros
                    else if (variaveis.Num_1_i == 2)
                    {
                        Console.Write("Crocodilo\n");
                    }
                    //Sem patas
                    else if (variaveis.Num_1_i == 3)
                    {
                        Console.Write("Cobra\n");
                    }
                }
                Console.WriteLine("Qual a Categoria do Pet:\n0 = Para Sair: \n1 = Mamífero: \n2 = Ave: \n3 = Réptil: ");
                variaveis.Num_1_i = int.Parse(Console.ReadLine());
            }
        }
    }
}
