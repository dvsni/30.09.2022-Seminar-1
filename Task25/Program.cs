// Напишите цикл, который 
// принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);

int multify = a;
for (int i = 1; i < b; i++)
{
    multify = multify * a;
}
Console.WriteLine($"Число {a} в степени {b} = {multify}");