using System;

class SomaPrimosMatriz
{
    // Função para verificar se um número é primo
    static bool EhPrimo(int numero)
    {
        if (numero < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        // Exemplo de matriz
        int[,] matriz = {
            { 2, 4, 5 },
            { 7, 10, 11 },
            { 13, 16, 17 }
        };

        int somaPrimos = 0;

        // Percorre a matriz e soma os números primos
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (EhPrimo(matriz[i, j]))
                {
                    somaPrimos += matriz[i, j];
                }
            }
        }

        Console.WriteLine("A soma dos números primos na matriz é: " + somaPrimos);
    }
}

