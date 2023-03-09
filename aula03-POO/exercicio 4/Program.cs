public class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno("Matheus",0,0);
        Console.WriteLine($"Media: {aluno1.Media(10,9.5).ToString("F2")}");
    }
}