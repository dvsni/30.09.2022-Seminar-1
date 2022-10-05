// Напишите программу, которая
// принимает на вход два числа
// и проверяет, является ли одно число квадратом другого
// 5,25->да
// -4,16->да
// 25,5->да
// 8,9->нет

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool CheckingNumbers(int number1, int number2)
{
    int min = number1;
    int max = number2;
    if (number1 > number2)
    {
        min = number2;
        max = number1;
    }
    return min * min == max;
}
bool result = CheckingNumbers(num1, num2);
if (result) Console.WriteLine("Да");
else Console.WriteLine("Нет");