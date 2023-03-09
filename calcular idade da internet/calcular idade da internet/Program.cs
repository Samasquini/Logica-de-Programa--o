using System;
class estudo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua data de nascimento:");
        var a = DateTime.TryParse(Console.ReadLine(), out var b);
        DateTime atual = DateTime.Now;
        Console.WriteLine(calculaIdade(b, atual));
    }
    static string calculaIdade(DateTime dNascimento, DateTime dAtual)
    {
        int idDias = 0, idMeses = 0, idAnos = 0;
        DateTime dNascimentoCorrente = DateTime.Parse(dNascimento.Day.ToString() + "/" +
        dNascimento.Month.ToString() + "/" + (dAtual.Year - 1).ToString());
        string ta = "", tm = "", td = "";
        if (dAtual < dNascimento)
        {
            return "Data de nascimento inválida ";
        }
        idAnos = dAtual.Year - dNascimento.Year;
        if (dAtual.Month < dNascimento.Month || (dAtual.Month ==
        dNascimento.Month && dAtual.Day < dNascimento.Day))
        {
            idAnos--;
        }
        idMeses = calculaMeses(dAtual, dNascimento);
        idDias = calculaDias(dAtual, dNascimento);
        if (idAnos > 1)
            ta = idAnos + " anos ";
        else if (idAnos == 1)
            ta = idAnos + "ano";
        if (idMeses > 1)
            tm = idMeses + " meses ";
        else if (idMeses == 1)
            tm = idMeses + " mês ";
        if (idDias > 1)
            td = idDias + " dias ";
        else if (idDias == 1)
            td = idDias + " dia ";
        return ta + tm + td;
    }
    static int calculaDias(DateTime dataAtual, DateTime dataOriginal)
    {
        int numeroDias = 0;
        if ((dataAtual.Month > dataOriginal.Month || dataAtual.Month <
        dataOriginal.Month) && (dataAtual.Day > dataOriginal.Day))
        {
            DateTime dUltima = DateTime.Parse(dataOriginal.Day.ToString() + "/" +
            (dataAtual.Month).ToString() + "/" + (dataAtual.Year).ToString());
            numeroDias = (dataAtual - dUltima).Days;
        }
        else if ((dataAtual.Month > dataOriginal.Month || dataAtual.Month <
        dataOriginal.Month) && (dataAtual.Day < dataOriginal.Day))
        {
            DateTime dUltima = DateTime.Parse(dataOriginal.Day.ToString() + "/" +
            (dataAtual.Month - 1).ToString() + "/" + (dataAtual.Year).ToString());
            numeroDias = (dataAtual - dUltima).Days;
        }
        else if (dataOriginal.Month == dataAtual.Month)
        {
            DateTime dUltima = DateTime.Parse(dataOriginal.Day.ToString() + "/" +
            (dataAtual.Month).ToString() + "/" + (dataAtual.Year).ToString());
            numeroDias = (dataAtual - dUltima).Days;
        }
        return numeroDias;
    }
    static int calculaMeses(DateTime dataAtual, DateTime dataOriginal)
    {
        int numeroMeses = 0;
        if ((dataAtual.Month > dataOriginal.Month))
        {
            numeroMeses = dataAtual.Month - dataOriginal.Month;
        }
        else if ((dataAtual.Month < dataOriginal.Month))
        {
            if (dataAtual.Day > dataOriginal.Day)
            {
                numeroMeses = (12 - dataOriginal.Month) + (dataAtual.Month);
            }
            else if (dataAtual.Day < dataOriginal.Day)
            {
                numeroMeses = (12 - dataOriginal.Month) + (dataAtual.Month - 1);
            }
        }
        return numeroMeses;
    }
}