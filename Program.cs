using System;

class Program
{
    static void Main()
    {
        int[,] tabela = new int[2,3];

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write("Digite um número: ");
                tabela[linha,coluna] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nTabela:");

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write(tabela[linha,coluna] + "\t");
            }

            Console.WriteLine();
        }
    }
}