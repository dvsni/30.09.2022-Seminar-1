// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] array = new double[4, 2];
FillRndMatrix2D(array, -9, 11);
Console.WriteLine("Исходный массив ниже:");
PrintArrayTwo(array);

double[] averege = new double[array.GetLength(1)];
averege = AvgCol(array);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
PrintArray(averege, 1);

void PrintArray(double[] arr, int index)
{
    Console.Write("[");
    for (int i = -1 + index; i < arr.Length; i += index)
    {
        if
        (i < arr.Length - index)
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {

            Console.Write($"{arr[i]}");
        }
    }
    Console.WriteLine("]");
}

double[] AvgCol(double[,] arr)
{
    double[] avgMatrix = new double[arr.GetLength(1)];
    double tempSum = default;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            tempSum += arr[i, j];
        }
        avgMatrix[j] = Math.Round(tempSum / arr.GetLength(0), 2);
        tempSum = default;
    }
    return avgMatrix;
}

void FillRndMatrix2D(double[,] arr, int mins, int maxs)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round((rnd.NextDouble() * (maxs - mins) + mins), 1);
        }
    }
}

void PrintArrayTwo(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],4}, ");
            else Console.Write($"{arr[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}