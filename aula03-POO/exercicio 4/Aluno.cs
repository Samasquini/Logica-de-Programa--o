public class Aluno
{
    public string nome;
    public string eMail;
    public double nota1;
    public double nota2;

    public Aluno()
    {

    }
    public Aluno(string nome, double nota1, double nota2)
    {
        this.nome = nome;
        this.nota1 = nota1;
        this.nota2 = nota2;

    }
    public double Media(double nota1, double nota2)
    {
        this.nota1 = nota1;
        this.nota2 = nota2;
        return (nota1 + nota2) / 2;
    }
}