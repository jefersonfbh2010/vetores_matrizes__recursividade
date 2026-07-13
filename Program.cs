using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3,3];
        int maior = int.MinValue;

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write("Digite um número: ");
                matriz[linha,coluna] = Convert.ToInt32(Console.ReadLine());

                if (matriz[linha,coluna] > maior)
                {
                    maior = matriz[linha,coluna];
                }
            }
        }

        Console.WriteLine("\nMaior valor: " + maior);
    }
}