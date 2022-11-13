// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите с какого числа начать заполнение массива: ");
int startValue = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
FillSpirally(array, startValue);
Console.WriteLine("Спирально заполненный массив: ");
PrintArrayTwo(array);

void FillSpirally(int[,] arr, int firstVal)
{
    int totalDigits = arr.GetLength(0) * arr.GetLength(1);
    int i = 0;
    int j = 0;
    int k =1;
    arr[i, j] = firstVal;
    int prevValue = default;
    while (k< totalDigits)
    {
        prevValue = arr[i, j];
        if (((j + 1 < arr.GetLength(1))&&(arr[i, j + 1] == 0))&&((i==0)||(arr[i-1,j]!=0)))
        {
            j++;
        }
        else
        {
            if ((i + 1 < arr.GetLength(0))&&(arr[i + 1, j] == 0) )
            {
                i++;
            }
            else
            {
                if ((j - 1 >= 0)&&(arr[i, j - 1] == 0) )
                {
                    j--;
                }
                else
                {
                    if ((i - 1 >= 0)&&(arr[i - 1, j] == 0))
                    {
                        i--;
                    }
                   
                }
            }
        }
         arr[i, j] = prevValue + 1;
         k++;
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