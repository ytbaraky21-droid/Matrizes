using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];
        int soma = 0;

        Console.WriteLine("Digite os valores da matriz 3x3:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                int valor = int.Parse(Console.ReadLine());
                matriz[i, j] = valor;
                soma += valor;
            }
        }

        Console.WriteLine($"\nA soma de todos os elementos da matriz é: {soma}");
    }
}
