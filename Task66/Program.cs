// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

Console.WriteLine($"Сумма натуральных чисел от {num1} до {num2} = {SumNaturalNum(num1, num2)}");

int SumNaturalNum(int num1, int num2)
{
    if(num1 == num2) return num1;
    SumNaturalNum(num1 + 1, num2);
    return SumNaturalNum(num1 + 1, num2) + num1;
}

