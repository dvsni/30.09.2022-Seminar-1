// Напишите программу, которая 
// принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// // 1 метод:
// Console.WriteLine("Введите трехзначное число: ");
// int firstDigit1 = Convert.ToInt32(Console.ReadLine());
// string number1 = Convert.ToString(firstDigit1);
// Console.WriteLine("Вторая цифра числа -> "+number1[1]);

// // 2 метод:
// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int digitIndex = 1;
// int digit = number.ToString()[digitIndex] - '0';
// Console.WriteLine($"Вторая цифра числа-> {digit}");

//3 метод:

//4-й метод:
// Console.WriteLine ("Введите трехзначное число");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine ($"Вторая цифра в числе-> {number/10%10}");

Console.WriteLine("Введите трёхзначное число: "); 
int number = Convert.ToInt32(Console.ReadLine()); 
 
int firstDigit = number/100; 
int twoDigitsNumber = number - 100*firstDigit; 
int secondDigit = twoDigitsNumber/10; 
 
Console.WriteLine($"Вторая цифра в числе-> {secondDigit}");