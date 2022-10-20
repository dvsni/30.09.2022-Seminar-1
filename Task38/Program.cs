// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] FillArrayRnd(double[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        arr[i] = Math.Round((rnd.Next(min, max + 1)) * 1.16, 1);
    }
    return arr;
}
double[] MiniMaxi(double[] arr)
{
    double[] minimaxivalues = new double[2];
    minimaxivalues[1] = arr[0];
    minimaxivalues[0] = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > minimaxivalues[1])
        {
            minimaxivalues[1] = arr[i];
        }
        if (arr[i] < minimaxivalues[0])
        {
            minimaxivalues[0] = arr[i];
        }
    }

    return minimaxivalues;
}
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if
        (i < arr.Length - 1)
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


double[] array = new double[10];
FillArrayRnd(array, 10, 100);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
double dif = MiniMaxi(array)[1] - MiniMaxi(array)[0];
Console.WriteLine($"Разница между максимальным и минимальным элементами равна: {Math.Round(dif, 1)}");
