// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.Write("Введите количество строк матрицы: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов матрицы: ");
int col = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество глубин матрицы: ");
int depth = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = new int[row, col, depth];
int[,] matrix2d = new int[row * col * depth, 5];
int minRndVal = 10;
int maxRndVal = 20;

CheckForCapacity(row, col, depth, minRndVal, maxRndVal);
FillRndMatrix3D(matrix, minRndVal, maxRndVal);
matrix2d = Arr3dTo2d(matrix);
PrintMatrixByRows(matrix2d);
SortArr3dParam(matrix2d, 0);

while (CheckDublicates(matrix2d) == true)
{
    SortArr3dParam(matrix2d, 0);
    ChangeDublicates(matrix2d, minRndVal, maxRndVal);
}

SortArr3dParam(matrix2d, 4);
Console.WriteLine("Трёхмерная матрица построчно:");
PrintMatrixByRows(matrix2d);
//__________________________________________________________
void FillRndMatrix3D(int[,,] arr, int mins, int maxs)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = rnd.Next(mins, maxs + 1);
                Console.Write($"{arr[i, j, k]} ");
            }
        }
    }
    Console.WriteLine(" ");
}

int[,] Arr3dTo2d(int[,,] arr)
{
    int[,] to2d = new int[row * col * depth, 5];
    int i = 0;
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            for (int l = 0; l < arr.GetLength(2); l++)
            {
                to2d[i, 0] = arr[j, k, l]; Console.Write($"{arr[j, k, l]}");
                to2d[i, 1] = j; Console.Write($" {to2d[i, 1]}");
                to2d[i, 2] = k; Console.Write($" {to2d[i, 2]}");
                to2d[i, 3] = l; Console.Write($" {to2d[i, 3]}");
                to2d[i, 4] = j * 100 + 10 * k + l; Console.Write($" {to2d[i, 4]}");
                Console.WriteLine(" ");
                i++;
            }
        }
    }
    return to2d;
}

void SortArr3dParam(int[,] arr, int param)
{
    int temp = arr[0, param];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(0) - 1; j++)
        {
            if (arr[j, param] > arr[j + 1, param])
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    temp = arr[j, k];
                    arr[j, k] = arr[j + 1, k];
                    arr[j + 1, k] = temp;
                }
            }
        }
    }
}

void ChangeDublicates(int[,] arr, int mins, int maxs)
{
    Random rnd = new Random();
    for (int i = 1; i < arr.GetLength(0) - 1; i++)
    {
        while ((arr[i, 0] == arr[i - 1, 0]) || (arr[i, 0] == arr[i + 1, 0]))
        {
            arr[i, 0] = rnd.Next(mins, maxs + 1);
        }
    }
}

bool CheckDublicates(int[,] arr)
{
    bool dubExist = false;
    SortArr3dParam(arr, 0);
    for (int i = 1; i < arr.GetLength(0) - 1; i++)
    {
        if ((arr[i, 0] == arr[i - 1, 0]) || (arr[i, 0] == arr[i + 1, 0]))
        {
            dubExist = true;
            return dubExist;
        }
    }
    return dubExist;
}

void PrintMatrixByRows(int[,] arr)
{
    Console.WriteLine(" ");
    Console.Write($"{arr[0, 0]} ({arr[0, 1]}, {arr[0, 2]}, {arr[0, 3]}) ");
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (arr[i, 1] > arr[i - 1, 1])
        {
            Console.WriteLine(" ");
            Console.Write($"{arr[i, 0]} ({arr[i, 1]}, {arr[i, 2]}, {arr[i, 3]}) ");
        }
        else
            Console.Write($"{arr[i, 0]} ({arr[i, 1]}, {arr[i, 2]}, {arr[i, 3]}) ");
    }
    Console.WriteLine("");
    Console.WriteLine("________________________");
}

void CheckForCapacity(int r, int c, int d, int minRnd, int maxRnd)
{
    int gap = maxRnd - minRnd;
    int capacity = r * c * d;
    if (gap < capacity)
    {
        Console.WriteLine("Для массива такого размера не хватит количества целых чисел из диапазона рандомных значений.");
        Environment.Exit(0);
    }
}
