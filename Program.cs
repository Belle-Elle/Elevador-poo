using System;

namespace Lista_exercicios_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                elevador E = new elevador();
                Serviço S = new Serviço();
                Publico P = new Publico();
                P.Inicializar();

                Console.WriteLine("Insira o numero de Andares que o Elevador terá ");
                E.TotalAndares = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira o numero de Pessoas que o elevador sera capaz de aguentar");
                E.Capacidade = int.Parse(Console.ReadLine());



                bool repetir = false;

                do
                {
                    Console.WriteLine("Qual elevador deseja usar: serviço ou o publico? (S = Seviço P = Publico)");
                    String resposta1 = Console.ReadLine().ToUpper();

                    switch (resposta1)
                    {
                        case "S":
                            Console.WriteLine($@"Digite o numero de uma opção para seguir:
1 - Entrar
2 - Sair
3 - Subir
4 - Descer
5 - Caixas
                        ");

                            String resposta2 = Console.ReadLine();

                            if (resposta2 == "1")
                            {
                                repetir = true;
                                Console.WriteLine(E.Entrar());
                            }
                            else if (resposta2 == "2")
                            {
                                repetir = true;
                                Console.WriteLine(E.Sair());
                            }
                            else if (resposta2 == "3")
                            {
                                repetir = true;
                                Console.WriteLine(E.Subir());
                            }
                            else if (resposta2 == "4")
                            {
                                Console.WriteLine(E.Descer());
                                repetir = true;
                            }
                            else if (resposta2 == "5")
                            {
                                Console.WriteLine(S.mCaixas());
                                repetir = true;
                            }
                            else
                            {
                                repetir = true;
                                Console.WriteLine("Resposta invaliada, digite novamente\n");
                            }
                            break;

                        case "P":
                            repetir = false;
                            Console.WriteLine($@"Digite o numero de uma opção para seguir:
1 - Entrar
2 - Sair
3 - Subir
4 - Descer
                        ");

                            String resposta3 = Console.ReadLine();

                            if (resposta3 == "1")
                            {
                                repetir = true;
                                Console.WriteLine(E.Entrar());
                            }
                            else if (resposta3 == "2")
                            {
                                repetir = true;
                                Console.WriteLine(E.Sair());
                            }
                            else if (resposta3 == "3")
                            {
                                repetir = true;
                                Console.WriteLine(E.Subir());
                            }
                            else if (resposta3 == "4")
                            {
                                Console.WriteLine(E.Descer());
                                repetir = true;
                            }
                            else
                            {
                                repetir = true;
                                Console.WriteLine("Resposta invaliada, digite novamente\n");
                            }
                            break;
                        default:
                            Console.WriteLine("Resposta invaliada, digite novamente\n");
                            repetir = true;
                            break;
                    }
                } while (repetir);


            }
        }
    }
}


