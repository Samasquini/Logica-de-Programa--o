public class Program
{
    static void Main(string[] args)
    {
        Livro sherlock = new Livro("Sherlock", "Sherlock Pai", "2000", "bmw12333");
        Pessoa deide = new Pessoa("Deide Costa", "70770770770", "shaulinmatadordeporco@gmail.com");

        Emprestimo livro1 = new Emprestimo();

        livro1.Emprestar(sherlock, deide);

        Console.WriteLine("\n7 dias depois...");

        Console.WriteLine("\nVocê deseja devolver o livro?" +
            "\n1 - Sim." +
            "\n2 - Não.");

        var a = int.TryParse(Console.ReadLine(), out var opc);

        if (opc == 1)
        {
            livro1.Devolver(sherlock, deide);
        }
        else
        {
            Console.WriteLine($"{deide.cpf}\nSó pra lembrar eu tenho seu cpf e voce esta ferrado(a) {deide.nome}");
        }
    }
}
