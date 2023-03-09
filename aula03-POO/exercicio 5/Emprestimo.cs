using System;

public class Emprestimo
{
    public DateTime emprestimoDia;
    public DateTime devolucao;

    public Livro livro;
    public Pessoa pessoa;
    
    public void Emprestar(Livro livro, Pessoa pessoa)
    {
       if(livro.status == true)
        {
            this.livro = livro;
            this.pessoa = pessoa;
            emprestimoDia = DateTime.Today;
            livro.status = false;
            Console.WriteLine("Livro emprestado com sucesso, devolva o livro em 7 dias");
        }
        else
        {
            Console.WriteLine("Livro indisponivel.");
        }
    }
    public void Devolver(Livro livro)
    {
        this.livro = livro;
        if (livro.status == false)
        {
            devolucao = DateTime.Today;
            livro.status = true;
            Console.Write("Obrigado por devolver, volte sempre.");
        }
        else
        {
            Console.WriteLine("Livro não foi emprestado.");
        }
    }
}