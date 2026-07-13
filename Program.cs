using System;

class Program
{
    static void Main()
    {
        // Vetor para guardar os nomes
        string[] nomes = new string[5];

        // Matriz para guardar as 3 notas de cada aluno
        double[,] notas = new double[5, 3];

        // Vetor para guardar a média
        double[] medias = new double[5];

        // Cadastro
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nome do aluno: ");
            nomes[i] = Console.ReadLine()!;

            double soma = 0;

            for (int j = 0; j < 3; j++)
            {
                Console.Write("Nota " + (j + 1) + ": ");
                notas[i, j] = Convert.ToDouble(Console.ReadLine());

                soma += notas[i, j];
            }

            medias[i] = soma / 3;
        }

        Console.WriteLine("\n===== BOLETIM =====");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("\nAluno: " + nomes[i]);
            Console.WriteLine("Média: " + medias[i].ToString("F2"));

            if (medias[i] >= 7)
            {
                Console.WriteLine("Situação: Aprovado");
            }
            else if (medias[i] >= 5)
            {
                Console.WriteLine("Situação: Recuperação");
            }
            else
            {
                Console.WriteLine("Situação: Reprovado");
            }
        }
    }
}