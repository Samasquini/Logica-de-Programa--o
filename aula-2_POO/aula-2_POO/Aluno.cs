public class Aluno
{
    public string nome;
    public string email;
    public double nota1;
    public double nota2;

    public void CaucularMedia()
    {
        double media = (nota1 + nota2) / 2;
        string estado;

        if(media <= 6)
        {
            estado = "reprovado";
        }
        else
        {
            estado = "aprovado";
        }
        Console.WriteLine($"A média é {media}.\nVocê está {estado}.");
    }
}
