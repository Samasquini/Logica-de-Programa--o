using System;
using System.ComponentModel.Design;

class Prova
{
    static void Main(string[] args)
    {
        //opção 2
       
        static double opc1(string gen, double altura)
        {
            if (gen.Contains("mulher") || gen.Contains("feminino") || gen.Contains("f"))
            {
                return (62.2 * altura) - 44.7;
            }
            else if (gen.Contains("homen") || gen.Contains("masculino") || gen.Contains("m"))
            {
                return (72.8 * altura) - 58;
            }
            return 0;
        }

        //opção 3

        static int Qntd_de_Pessoas()
        {
            Console.Write("Quantas pessoas irão comprar o pacote? ");
            int numDePesoas = int.Parse(Console.ReadLine());
            return numDePesoas;
        }
        static int Qntd_de_Pessoas_Por_Quarto(int pessoas)
        {
            string quarto;
        dnv:;
            if (pessoas < 3)
            {

                Console.Write("Quarto individual ou duplo? ");
                quarto = Console.ReadLine();
                if (quarto.Contains("individual"))
                {
                    return 1;
                }
                else if (quarto.Contains("duplo"))
                {
                    return 2;
                }
                else
                {
                    var a = int.TryParse(quarto, out var numero);
                    if (!a) { Console.WriteLine("Valor invalido."); goto dnv; }
                    if (numero == 1) return 1;
                    if (numero == 2) return 2;
                }
                return 0;
            }
            Console.Write("Quarto individual, duplo ou triplo? ");
            quarto = Console.ReadLine();

            if (quarto.Contains("individual"))
            {
                return 1;
            }
            else if (quarto.Contains("duplo"))
            {
                return 2;
            }
            else if (quarto.Contains("triplo"))
            {
                return 3;
            }
            
            else
            {
                var a = int.TryParse(quarto, out var numero);
                if (!a) { Console.WriteLine("Valor invalido."); goto dnv; }
                if (numero == 1) return 1;
                if (numero == 2) return 2;
                if (numero == 3) return 3;
            }
            return 0;
        }
        static DateTime[] DTarray(int NumPessoas)
        {
            DateTime[] idades = new DateTime[NumPessoas];
            for (int i = 0; i < idades.Length; i++)
            {
                Console.Write($"Digite a data de nascimento da pessoa n° {i + 1}: ");
                var a = DateTime.TryParse(Console.ReadLine(), out idades[i]);
            }
            return idades;
        }
        static double Pacote(int vs)
        {
            DateTime DtAtual = DateTime.Now;
            double soma = 0;
            DateTime[] Aniversario = DTarray(vs);
            for (int i = 0; i < Aniversario.Length; i++)
            {
                if (Ver_Aniver_Com_Intervalo(Aniversario[i], 0, 3)) soma += 0;
                if (Ver_Aniver_Com_Intervalo(Aniversario[i], 2, 8)) soma +=  (35000 * 0.41);
                if (Ver_Aniver_Com_Intervalo(Aniversario[i], 8, 62)) soma += 35000;
                if (VerificarAniversario(Aniversario[i], 62)) soma += (35000 * 0.83);
            }
            return soma;
        }
        static bool Ver_Aniver_Com_Intervalo(DateTime DtAniversario, int idade1, int idade2)
        {
            DateTime DtAtual = DateTime.Now;

            int[,] DATA = { { DtAniversario.Year, DtAniversario.Month, DtAniversario.Day }, { DtAtual.Year, DtAtual.Month, DtAtual.Day } };

            int anos = DATA[1, 0] - DATA[0, 0];
            if (anos > idade1 && anos < idade2) return true;
            if (anos == idade1 || anos == idade2)
            {
                if (DATA[0, 1] < DATA[1, 1]) return true;
                else if (DATA[0, 1] == DATA[1, 1])
                {
                    if (DATA[0, 3] <= DATA[1, 3]) return true;
                    else return false;
                }
                else return false;
            }
            return false;
        }
        static bool VerificarAniversario(DateTime DtAniversario, int idade)
        {
            DateTime DtAtual = DateTime.Now;
            int anos = DtAtual.Year - DtAniversario.Year;
            if (anos > idade) return true;
            if (anos == idade)
            {
                if (DtAniversario.Month < DtAtual.Month) return true;
                if (DtAniversario.Month == DtAtual.Month)
                {
                    if (DtAniversario.Day <= DtAtual.Day) return true;
                }
            }
            return false;
        }


        //menu

        static int Menu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1 - Sair do programa." +
                "\n2 - peso ideal." +
                "\n3 - pacote de viagem.");
            Console.Write("Escolha uma opção: ");
            int.TryParse(Console.ReadLine(), out var opc);
            Console.ResetColor();
            return opc;
        }
        while (true)
        {
            bool a;
            switch (Menu())
            {
                case 1:
                    goto saida;

                case 2:
                    Console.Write("Qual é o seu genero: ");
                    string genero = Console.ReadLine();
                    Console.Write("Digite a sua altura: ");
                    a = double.TryParse(Console.ReadLine(), out var altura);
                    Console.WriteLine("peso ideal = " + opc1(genero, altura).ToString("0.000"));
                    break;
                case 3:
                    int pessoas = Qntd_de_Pessoas();
                    if(pessoas <= 0)
                    {
                        Console.WriteLine("Quantidade de pessoas inválidas.");
                    }
                    else if(pessoas == 1)
                    {
                        Console.WriteLine($"O valor do pacote será de {(Pacote(pessoas) * 1.17).ToString("C2")}");
                    }
                    else if (pessoas > 1)
                    {
                        int Quarto = Qntd_de_Pessoas_Por_Quarto(pessoas);
                        if(Quarto <= 0)
                        {
                            Console.WriteLine("\nErro.\n");
                        }
                        else if(Quarto == 1)
                        {
                            Console.WriteLine($"O valor do pacote será de {(Pacote(pessoas) * 1.17).ToString("C2")}");
                        }
                        else if(Quarto == 2)
                        {
                            Console.WriteLine($"O valor do pacote será de {Pacote(pessoas).ToString("C2")}");
                        }
                        else if (Quarto == 3)
                        {
                            Console.WriteLine($"O valor do pacote será de {((Pacote(pessoas) * 0.94)).ToString("C2")}");
                        }

                    }


                    break;
            }
            Console.Write("\n");
        }
    saida:;
    }
}