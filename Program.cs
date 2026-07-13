using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }

        if (n == 1)
        {
            return 1;
        }

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.Write("Digite a posição: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Resultado: " + Fibonacci(numero));
    }
}