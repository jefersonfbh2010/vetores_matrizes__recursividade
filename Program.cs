using System;

class Program
{
    static void Main()
    {
        // Cria um vetor para guardar os nomes de 5 alunos
        string[] alunos = new string[5];

        // Lê os nomes
        for (int i = 0; i < alunos.Length; i++)
        {
            Console.Write("Digite o nome do aluno " + (i + 1) + ": ");
            alunos[i] = Console.ReadLine()!;
        }

        Console.WriteLine("\nAlunos cadastrados:");

        // Mostra todos os nomes
        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine(alunos[i]);
        }
    }
}