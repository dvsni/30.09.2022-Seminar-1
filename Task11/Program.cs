// Напишите программу, которая
// выводит случайное трехзначное число
// и удаляет вторую цифру этого числа
// 456->46
// 782->72
// 918->98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапазона 10 - 99 => {number}");
int firstDigit = number / 100; //456 / 100 = 4
int secondDigit = number % 10; //456 % 10 = 6
int number1 = firstDigit * 10 + secondDigit;
Console.WriteLine($"Две цифры {number1}");
