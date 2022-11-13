// Напишите программу, которая
// будет принимать на вход число
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    if (num == 1) return 0;
    else return num % 10 + SumDigits(num / 10);
}

int res = SumDigits(number);
Console.WriteLine(res);
