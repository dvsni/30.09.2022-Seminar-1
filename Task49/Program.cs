// Задайте двумерный масив.
// Найдите элементы, у которых оба индекса четные, 
// и замените эти элементы на их квадраты.
// 1 4 7 2                  1 4 49 2
// 5 9 2 3                  5 81 2 9
// 8 4 2 4                  64 4 4 4

int[,] CreateAMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void ChangeMatrix(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i+=2)
    {
        for (int j = 0; j < array2D.GetLength(1); j+=2)
        {
            array2D[i, j] *= array2D[j, j];
        }
    }
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
        else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateAMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);

Console.WriteLine();
ChangeMatrix(array2D);
PrintMatrix(array2D);
