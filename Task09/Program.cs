// Напишите программу, которая 
// выводит
// случайное число из отрезка [10,99] и 
// показывает наибольшую цифру числа.
// 78->8
// 12->2
// 85->8

int number = new Random().Next(10, 100);
// int number1 = new Random().Next(10);
// int number2 = new Random().Next();
Console.WriteLine($"Случайное число из диапазона 10 - 99 => {number}");
// int firstDigit = number / 10; //78 / 10 = 7.8
// int secondDigit = number % 10; //78 % 10 = 8
// if(firstDigit == secondDigit) Console.WriteLine($"Цифры одинаковые");
// else if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа = {secondDigit}");


int MaxDigit (int number)
{
    int firstDigit = number / 10; //78 / 10 = 7.8
    int secondDigit = number % 10; //78 % 10 = 8
    // if(firstDigit > secondDigit) return firstDigit;
    // return secondDigit;
    // int result = default;
    // if(firstDigit > secondDigit) result = firstDigit;
    // else result = secondDigit;

    // result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа = {maxDigit}");

// int res = Math.Max(firstDigit, secondDigit);
// Console.WriteLine($"Наибольшая цифра числа = {res}");





