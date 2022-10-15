// Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] number = new int[size];
RandomNumber(number);
Console.WriteLine("В данном массиве: ");
PrintArray(number);

void RandomNumber(int[] number)
{
    for (int i = 0; i < size; i++)
    {
        number[i] = new Random().Next(100, 1000);
    }
}

int count = 0;
for (int s = 0; s < number.Length; s++)
{
    if(number[s] % 2 == 0)
    count++;
}
Console.WriteLine($"из {number.Length} показанных чисел, {count} четных");

void PrintArray(int[] number)
{
    Console.Write("[");
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write($"{number[i]},");
    }
    Console.Write("]");
    Console.WriteLine();
}


