// Задайте прямоугольный двумерный массив. 
// апишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк массива: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[k, m];
int[,] sumsrow = new int[2, m];
FillRndMatrix2D(array, 1, 5);
PrintArrayTwo(array);
sumsrow = SumRows(array);
Console.WriteLine($"Суммы строк ниже:");
PrintArrayTwo(sumsrow);
SortSumsArr(sumsrow);
Console.WriteLine($"Отсортировали массив с суммами строк:");
PrintArrayTwo(sumsrow);
Console.WriteLine($"Ответ-> {ConclusionMinSumRow(sumsrow)}");


void FillRndMatrix2D(int[,] arr, int mins, int maxs)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(mins, maxs + 1);
        }
    }
}

void PrintArrayTwo(int[,] arr)
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

int[,] SumRows(int[,] arr)
{
    int[,] sumofrows = new int[2, arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumofrows[1, i] += arr[i, j];
            sumofrows[0, i] = i;
        }
    }
    return sumofrows;
}
void SortSumsArr(int[,] arr)
{
    int temp = arr[1, 0];
    for (int i = 0; i < arr.GetLength(1) - 1; i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            if (arr[1, j] > arr[1, j + 1])
            {
                temp = arr[1, j];
                arr[1, j] = arr[1, j + 1];
                arr[1, j + 1] = temp;
                temp = arr[0, j];
                arr[0, j] = arr[0, j + 1];
                arr[0, j + 1] = temp;
            }
        }
    }
}

string ConclusionMinSumRow(int[,] arr)
{
    string conclusion = default;
    if (arr[1, 0] == arr[1, 1])
    {
        conclusion = "Несколько одинаковых строк с минмамльной суммой элементов. Вот они: ";
        conclusion += arr[0, 0] + 1;
        int i = 0;
        while (arr[1, i] == arr[1, i + 1])
        {
            conclusion += ", ";
            conclusion += arr[0, i + 1] + 1;
            i++;
        }
    }
    else
    {
        conclusion = "Номер строки с минимальной суммой элементов = " + Convert.ToString(arr[0, 0] + 1);
    }
    return conclusion;
}