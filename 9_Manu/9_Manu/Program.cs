using System;
class manu
{
    static void Main(string[] args)
    {
        int opc = Convert.ToInt32(Console.ReadLine());
        switch (opc)
        {
            //colocar só o case no switch na main
            case 9:
                Console.WriteLine("Digite um numero");
                ulong num = Convert.ToUInt64(Console.ReadLine());
                if (Num_Per(num))
                {
                    Console.WriteLine($"{num} é perfeito.");
                }
                else
                {
                    Console.WriteLine($"{num} não é perfeito.");
                }
                break;
        }
    }
    //colocar as função no final
    static bool Num_Per(ulong num)
    {
        ulong soma = 0;
        for (ulong i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                soma = soma + i;
            }
        }
        if (soma == num)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}