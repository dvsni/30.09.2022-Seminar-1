// Задайте двумерный массив рамзера m на n,
// каждый элемент в массиве находится по
// формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0123
// 1234
// 2345

int[,] CreateAMatrixRndInt(int rows, int columns)
{
    var matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
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

int[,] array2D = CreateAMatrixRndInt(3, 4);
PrintMatrix(array2D);