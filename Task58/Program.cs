// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк матрицы А: ");
int arow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы А: ");
int acol = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк матрицы B: ");
int brow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы B: ");
int bcol = Convert.ToInt32(Console.ReadLine());
if (acol!=brow)
{
    Console.Write("Матрицы несогласованы по размерности.");
}
else
{
    int[,] arrayA = new int[arow, acol];
    int[,] arrayB = new int[brow, bcol];
    FillRndMatrix2D(arrayA, 1, 2);
    FillRndMatrix2D(arrayB, 1, 2);

    Console.WriteLine("Матрица А: ");
    PrintArrayTwo(arrayA);
    Console.WriteLine("Матрица В: ");
    PrintArrayTwo(arrayB);
    int[,] multiMatrix = new int[acol, brow];
    multiMatrix=MultiplyVectorsInt(arrayA,arrayB);
    Console.WriteLine("Матрица после умножения: ");
    PrintArrayTwo(multiMatrix);
}

int[,] MultiplyVectorsInt(int[,] arrA, int[,] arrB)
{
    int[,] multiMatrix= new int [arrA.GetLength(0),arrB.GetLength(1)];
    
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            multiMatrix[i,j] = Scalar(i,j,arrA,arrB);
        }
    }
return multiMatrix;
}

int Scalar (int ii,int jj, int [,] arrA,int [,] arrB)
{
int scal = default;
    for (int j = 0; j < arrB.GetLength(0); j++)
    { 
        scal+=arrA[ii,j]*arrB[j,jj];
    }
return scal;
}

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