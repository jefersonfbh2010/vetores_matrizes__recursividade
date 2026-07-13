using System;

class Program
{
    // Função recursiva
    static int Somar(int numero)
    {
        if (numero == 1)
        {
            return 1;
        }

        return numero + Somar(numero - 1);
    }

    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Soma = " + Somar(numero));
    }
}