using System;
class URI
{
    static void Main(string[] args)
    {
        int numero0 = 0;
        int numero1 = 0;
        int numero2 = 1;
        int[] fibo = new int[20];
        for (int i = 0; i < 20; i++)
        {
            numero0 = numero1;
            numero1 = numero2;
            numero2 = numero0 + numero1;
            fibo[i] = numero2;
        }
        Console.WriteLine(0);
        Console.WriteLine(1);
        for (int i = 0; i < 18; i++)
        {
            Console.WriteLine(fibo[i]);
        }
    }
}