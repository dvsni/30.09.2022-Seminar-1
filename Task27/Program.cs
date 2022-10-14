// Напишите программу, которая 
// принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumdigits = default;
int size = default(ConsoleReadLine());
int i = 1;
int divide = 1;
int lastDigit=0;
while (number > 0)
{
    lastDigit = number%10;
    sumdigits+=lastDigit;
    i++;
    number=number/10;
}
Console.WriteLine($"Сумма цифр -> {sumdigits} ");