// Напишите программу, которая
// принимает на вход число
// и выдает количество цифр в числе
// 456->3
// 78->2
// 89126->5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int NumbersCount(int num)
{
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}
int numbersCount = NumbersCount(number);
Console.WriteLine($"Количество цифр в числе -> {numbersCount}");
