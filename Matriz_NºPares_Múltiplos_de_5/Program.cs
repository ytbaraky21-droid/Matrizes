using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[4, 5];
        int pares = 0;
        int multiplosDe5 = 0;

        Console.WriteLine("Digite os valores da matriz 4x5 (inteiros positivos):");

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                int valor = int.Parse(Console.ReadLine());

                // Garante que o valor seja positivo
                while (valor <= 0)
                {
                    Console.Write("Valor inválido. Digite um inteiro positivo: ");
                    valor = int.Parse(Console.ReadLine());
                }

                matriz[i, j] = valor;

                if (valor % 2 == 0)
                    pares++;

                if (valor % 5 == 0)
                    multiplosDe5++;
            }
        }

        Console.WriteLine($"\nQuantidade de números pares: {pares}");
        Console.WriteLine($"Quantidade de múltiplos de 5: {multiplosDe5}");
    }
}

