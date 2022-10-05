// Напишите программу, которая 
// принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int firstDigit1 = Convert.ToInt32(Console.ReadLine());
string number1 = Convert.ToString(firstDigit1);
Console.WriteLine("Вторая цифра числа -> "+number1[1]);
