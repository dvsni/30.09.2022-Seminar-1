// Напишите программу, которая
// выводит массив из 8 элементов
// заполненный нулями и единицами
// в случайном порядке
// [1,0,1,1,0,1,0,0]



int[] FillArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int[] myArray = FillArray(8);
PrintArray(myArray);
