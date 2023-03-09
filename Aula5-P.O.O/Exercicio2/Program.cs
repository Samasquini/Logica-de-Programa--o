public class Program
{
    static void Main(string[] args)
    {
        Gabarito gabarito = new Gabarito();
        Prova Matheus = new Prova(gabarito);
        int cont = 0;
        while(cont < 16)
        {
            cont++;
            Console.WriteLine("Digite a resposta:");
            string resposta = Console.ReadLine().ToUpper();
            Matheus.RespostaAluno(resposta);
        }
        Console.WriteLine($"Acertos do Matheus: {Matheus.Acertos()}");
        Console.WriteLine($"Nota do Matheus: {Matheus.Nota()}");

        Prova Joao = new Prova(gabarito);
        cont = 0;
        while(cont < 16)
        {
            cont++;
            Console.WriteLine("Digite a resposta:");
            string resposta = Console.ReadLine().ToUpper();
            Joao.RespostaAluno(resposta);
        }
        Console.WriteLine($"Acertos do João: {Joao.Acertos()}");
        Console.WriteLine($"Nota do João: {Joao.Nota()}");
    }
}