using System;
class att
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de pessoas");
        int quantidadePessoas = Convert.ToInt32(Console.ReadLine());
        byte[] pessoas = new byte[quantidadePessoas];
        for(int i = 0 ; i < quantidadePessoas; i++)
        {
            Console.WriteLine($"Digite a data de nascimento da pessoa {i=1}");
            pessoas[i] = calculaIdade(Convert.ToDateTime(Console.ReadLine()));
        }
        
    }
    static double calc(byte[] idade)
    {
        double soma = 0;
        for(int i = 0; i < idade.Length; i++)
        {
            if (idade[i] < 3)
            {
                soma += 0;
            }
            else if(idade[i] >= 65)
            {
                soma += (34220 * 0.18);
            }
        }
        return soma;
    }
    static byte calculaIdade(DateTime dataNascimento)
    {
        return (byte)((DateTime.Today - dataNascimento).Days / 365.2425);
    }
}
