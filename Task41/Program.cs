//  Пользователь вводит с клавиатуры M чисел. 
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void FillArrayManually(int[] arr, int size)
{
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine($"Введи число №{i + 1}");
        arr[i] = Convert.ToInt32(System.Console.ReadLine());
    }
}

int CheckPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    int size = array.Length;
    Console.Write($"[{array[0]}");
    for (int i = 0; i < size; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.WriteLine($"]");
}

System.Console.WriteLine("Количество цифр, которые вы хотите ввести: ");
int number = Convert.ToInt32(System.Console.ReadLine());
int[] array = new int[number];
FillArrayManually(array, number);
System.Console.WriteLine("Введённые числа в виде массива ->");
PrintArray(array);
int positivecount = CheckPositiveNumbers(array);
System.Console.WriteLine($"Вы ввели {positivecount} числа больше нуля.");