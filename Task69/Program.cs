// Напишите программу, которая
// на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурсии.
// А = 3; B = 5 - > 243 (3^5)
// А = 2; B = 3 - > 8

Console.WriteLine("Введите первое целое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int Power (int num1, int num2)
{
    if(num2 == 0) return 1;
        return num1 * Power(num1, num2 -1);
}

int res = Power(number1,number2);
Console.WriteLine(res);