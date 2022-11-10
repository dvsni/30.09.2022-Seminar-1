// Задайте двумерный массив.
// Напишите программу, которая
// поменяет местами первую и последнюю строку массива

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
void PrintRowsColumsIndex(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
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

int[,] array2D = CreateAMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine("");
PrintRowsColumsIndex(array2D);
PrintMatrix(array2D);
