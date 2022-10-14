// Напишите программу, 
// которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//1-ый способ:

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= number; i++)
Console.WriteLine($"{Math.Pow(i, 3)} ");

//2-й способ:

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int i=1;
// while (i<=number)
// {
// Console.WriteLine($" {i} | {i*i*i} ");
// i++;
// }
