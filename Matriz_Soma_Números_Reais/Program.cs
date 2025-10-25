using System;

class Program
{
    static void Main()
    {
        // Define a matriz 4x3 de números reais
        double[,] matriz = new double[4, 3];

        Console.WriteLine("Digite os valores da matriz 4x3 (números reais):");

        // Leitura dos elementos da matriz
        for (int linha = 0; linha < 4; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write($"Elemento [{linha},{coluna}]: ");
                string entrada = Console.ReadLine();

                // Tenta converter a entrada para double
                if (double.TryParse(entrada, out double valor))
                {
                    matriz[linha, coluna] = valor;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                    coluna--; // Repete a leitura da mesma posição
                }
            }
        }

        Console.WriteLine("\n--- Soma dos elementos por linha ---");

        // Calcula e imprime a soma de cada linha
        for (int linha = 0; linha < 4; linha++)
        {
            double somaLinha = 0;

            Console.Write($"Linha {linha}: ");
            for (int coluna = 0; coluna < 3; coluna++)
            {
                double valor = matriz[linha, coluna];
                somaLinha += valor;

                // Exibe cada valor para facilitar a depuração
                Console.Write($"{valor:F2} ");
            }

            Console.WriteLine($"=> Soma = {somaLinha:F2}");
        }
    }
}
