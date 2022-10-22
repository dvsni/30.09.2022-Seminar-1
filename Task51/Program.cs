// Задайте двумерный массив.
// Найдите сумму элементов, находящихся 
// на главной диагонали (с индексами (0,0); (1,1)) и т.д.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12

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

int SumElements(int[,] matrix)
{
    int sum = default;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == j) sum += matrix[i, j];
        }
    }
    return sum;
}

int SumElements2(int[,] matrix)
{
    int sum = default;
    int length = 0;
    if (matrix.GetLength(0) > matrix.GetLength(1)) length = 1;
    for (int i = 0; i < matrix.GetLength(length); i++)
    {
       sum += matrix[i, i];
    }
    return sum;
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

int[,] array2D = CreateAMatrixRndInt(4, 3, 1, 10);
PrintMatrix(array2D);

int sumElements = SumElements2(array2D);
Console.WriteLine(sumElements);

