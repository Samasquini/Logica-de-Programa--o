using System.Xml;

public class Prova
{
    private Gabarito gabarito;
    private int cont;
    private int acertos;
    private double nota;

    public Prova(Gabarito gabarito)
    {
        this.gabarito = gabarito;
    }
    public bool RespostaAluno(string resposta)
    {
        cont++;
        if (cont == 1)
        {
            if (resposta.Contains(gabarito.RespostaQuestao(cont)))
            {
                acertos++;
                nota += 0.5;
                return true;
            }
            else
            {
                return false;
            }
        }if(cont == 2)
        {
            if (resposta.Contains(gabarito.RespostaQuestao(cont)))
            {
                acertos++;
                nota += 0.5;
                return true;
            }
            else
            {
                return false;
            }
        }if(cont == 3)
        {
            if (resposta.Contains(gabarito.RespostaQuestao(cont)))
            {
                acertos++;
                nota += 0.5;
                return true;
            }
            else
            {
                return false;
            }
        }if(cont == 4)
        {
            if (resposta.Contains(gabarito.RespostaQuestao(cont)))
            {
                acertos++;
                nota += 0.5;
                return true;
            }
            else
            {
                return false;
            }
        }if(cont == 5)
        {
            if (resposta.Contains(gabarito.RespostaQuestao(cont)))
            {
                acertos++;
                nota += 0.5;
                return true;
            }
            else
            {
                return false;
            }
        }if(cont == 6)
        {
            if (resposta.Contains(gabarito.RespostaQuestao(cont)))
            {
                acertos++;
                nota += 0.5;
                return true;
            }
            else
            {
                return false;
            }
        }if(cont == 7)
        {
            if (resposta.Contains(gabarito.RespostaQuestao(cont)))
            {
                acertos++;
                nota += 0.5;
                return true;
            }
            else
            {
                return false;
            }
        }if(cont == 8)
        {
            if (resposta.Contains(gabarito.RespostaQuestao(cont)))
            {
                acertos++;
                nota += 0.5;
                return true;
            }
            else
            {
                return false;
            }
        }if(cont == 9)
        {
            if (resposta.Contains(gabarito.RespostaQuestao(cont)))
            {
                acertos++;
                nota += 0.5;
                return true;
            }
            else
            {
                return false;
            }
        }if(cont == 10)
        {
            if (resposta.Contains(gabarito.RespostaQuestao(cont)))
            {
                acertos++;
                nota += 0.5;
                return true;
            }
            else
            {
                return false;
            }
        }if(cont == 11)
        {
            if (resposta.Contains(gabarito.RespostaQuestao(cont)))
            {
                acertos++;
                nota += 1;
                return true;
            }
            else
            {
                return false;
            }
        }if(cont == 12)
        {
            if (resposta.Contains(gabarito.RespostaQuestao(cont)))
            {
                acertos++;
                nota += 1;
                return true;
            }
            else
            {
                return false;
            }
        }if(cont == 13)
        {
            if (resposta.Contains(gabarito.RespostaQuestao(cont)))
            {
                acertos++;
                nota += 1;
                return true;
            }
            else
            {
                return false;
            }
        }if(cont == 14)
        {
            if (resposta.Contains(gabarito.RespostaQuestao(cont)))
            {
                acertos++;
                nota += 1;
                return true;
            }
            else
            {
                return false;
            }
        }if(cont == 15)
        {
            if (resposta.Contains(gabarito.RespostaQuestao(cont)))
            {
                acertos++;
                nota += 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;
    }
    public int Acertos()
    {
        return acertos;
    }
    public double Nota()
    {
        return nota;
    }
    public double Maior(Prova aluno1,Prova aluno2)
    {
        double nota1 = aluno1.Nota();
        double nota2 = aluno2.Nota();
        if (nota1 > nota2)
        {
            return nota1;
        }
        else if(nota1 < nota2)
        {
            return nota2;
        }
        else
        {
            return -1;
        }
    }

}