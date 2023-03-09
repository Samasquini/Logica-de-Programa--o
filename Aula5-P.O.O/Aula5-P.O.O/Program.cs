public class Program
{
    static void Main(string[] args)
    {
        Voo voo1 = new Voo(202, new DateTime(2004, 12, 21));
        while (true)
        {
            Console.WriteLine("Digite o assento");
            var a = int.TryParse(Console.ReadLine(), out var numCadeira);
            if (voo1.Ocupa(numCadeira))
            {
                Console.WriteLine($"Acento desocupado, seu acento é o {numCadeira}");
            }
            else if(voo1.Vagas() <= 0)
            {
                Console.WriteLine("Desculpa não foi possivel encontrar um acento disponivel");goto fim;
            }
            else
            {
                Console.WriteLine("Acento ocupado, você sera realocado para outro acento.");
                int acentoLivre = voo1.ProximoLivre();
                if (voo1.Ocupa(acentoLivre))
                {
                    Console.WriteLine($"Acento desocupado, seu acento agora é o {acentoLivre}.");
                }
            }
        }
    fim:;
    }
}