using System;

class Program
{
    static void Contagem(int numero)
    {
        Console.WriteLine(numero);

        if (numero == 0)
        {
            return;
        }

        Contagem(numero - 1);
    }

    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Contagem(numero);
    }
}