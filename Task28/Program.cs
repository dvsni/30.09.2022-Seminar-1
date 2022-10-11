// Напишите программу, которая
// принимает на вход число N
// и выдает произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} -> {factorial} ");

int Factorial(int number)
{
    int fact = 1;
    for (int i = 1; i <= number; i++)
    {
        checked
        {
            fact = fact * i;
        }
    }
    return fact;
}