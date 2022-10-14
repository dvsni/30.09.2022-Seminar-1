// Задайте массив.
// Напишите программу, которая
// определяет, присутствует ли заданное число в массиве
// 4; массив [6,7,19,345,3] - > нет
// 3; массив [6,7,19,345,3] -> да

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

bool SearchArrayNum(int[] array, int num)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num) 
        {
            result = true;
            break;
    }
    }
    return result;
}

int[] arr = {6, 7, 19, 345, 3};
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintArray(arr);
if(SearchArrayNum(arr, number )) Console.WriteLine("Да");
else Console.WriteLine("Нет");

