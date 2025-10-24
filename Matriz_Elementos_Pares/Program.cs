using System;

class Program
{
    static void Main()
    {
        // Definindo uma matriz 3x3 como exemplo
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Elementos pares da matriz:");

        // Percorrendo a matriz
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] % 2 == 0)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }
        }
    }
}
