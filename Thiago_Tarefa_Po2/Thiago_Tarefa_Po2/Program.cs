using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Voo voo1 = new Voo(1, DateTime.Today);
        voo1.cadeirasDoVoo = new bool[100];
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1-proximo acento livre.\n2-verifica\n3-ocupa\n4-Vagas");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Cadeira num° " + voo1.ProximaLivre() + " desocupada.");
                    break;
                case 2:
                    Console.WriteLine("Qual o numero da cadeira: ");
                    int cadeira = Convert.ToInt32(Console.ReadLine());
                    if (voo1.Verifica(cadeira))
                    {
                        Console.WriteLine("Cadeira ocupada");
                    }
                    else
                    {
                        Console.WriteLine("Cadeira desocupada");
                    }
                    break;
                case 3:
                    Console.WriteLine("Qual o numero da cadeira: ");
                    int cadeira1 = Convert.ToInt32(Console.ReadLine());
                    voo1.Ocupa(cadeira1);
                    Console.WriteLine("Cadeira ocupada.");
                    break;
                case 4:
                    Console.WriteLine("Num° de cadeiras vagas: " + voo1.Vagas());
                    break;
            }
            Console.ReadKey();
        }


    }
}