//  Задайте одномерный массив, 
//  заполненный случайными числами. 
//  Найдите сумму элементов, 
//  стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArrayRnd(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, int index)
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

int SumNechetElem(int[] arr)
{
    int sum = default;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum += arr[i];
    }
    return sum;
}

int[] array = new int[10];
FillArrayRnd(array, 100, 999);
Console.WriteLine($"Исходный массив:");
PrintArray(array, 1);
Console.WriteLine($"Каждый нечётный элемент массива:");
PrintArray(array, 2);
int sumNechetElem = SumNechetElem(array);
Console.WriteLine($"Сумма нечётных элементов массива -> {sumNechetElem}");