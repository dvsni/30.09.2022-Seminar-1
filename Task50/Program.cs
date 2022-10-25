// Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

double[,] array = new double[5, 5];
FillRndMatrix2D(array, -9, 11);
Console.WriteLine("Исходный массив ниже:");
PrintArrayTwo(array);

Console.Write("Введите номер строки элемента, который нужно найти: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента, который нужно найти: ");
int n = Convert.ToInt32(Console.ReadLine());
SearchElem(array, m, n);

void SearchElem(double[,] arr, int row, int col)
{
    if ((row >= arr.GetLength(0)) || (col >= arr.GetLength(1)))
        Console.WriteLine("Такого элемента в массиве нет");
    else
        Console.WriteLine($"Значение элемента: {arr[row - 1, col - 1]} ");
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