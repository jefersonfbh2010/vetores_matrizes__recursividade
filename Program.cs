using System;

class Program
{
    static void Main()
    {
        double[] notas = new double[5];
        double soma = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write("Digite a nota do aluno " + (i + 1) + ": ");
            notas[i] = Convert.ToDouble(Console.ReadLine());

            soma += notas[i];
        }

        double media = soma / notas.Length;

        Console.WriteLine("\nMédia da turma: " + media.ToString("F2"));
    }
}