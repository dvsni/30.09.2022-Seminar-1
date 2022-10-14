// Напишите программу, которая 
// задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Вводим массим из 8 чисел :");

int[] FillArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 41);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write($"[{array[0]}");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.Write($"]");
}

int [] myArray = FillArray(8);
PrintArray(myArray);
