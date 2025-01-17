﻿// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите размерность массива: m - количество строк, n - количество столбцов");
Console.Write("m -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n => ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное и максимальное значение элементов массива:");
Console.Write("min -> ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("max -> ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];
FillRndMatrix2D(array, min, max);
PrintArrayTwo(array);

void FillRndMatrix2D(double[,] arr, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
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