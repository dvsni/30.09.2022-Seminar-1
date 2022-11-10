// Задайте двумерный массив.
// Напишите программу, которая
// заменяет строки на столбцы.
// В случае, если это невозможно,
// программа должна вывести сообщение для пользователя

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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
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
        else Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateAMatrixRndInt(4, 4, 1, 10);
if (array2D.GetLength(0) == array2D.GetLength(1))
{
    PrintMatrix(array2D);
    Console.WriteLine("");
    PrintRowsColumsIndex(array2D);
    PrintMatrix(array2D);
}
else Console.Write("невозможно");

