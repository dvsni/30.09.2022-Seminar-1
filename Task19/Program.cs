// Напишите программу, 
// которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//1-ый способ:

Console.WriteLine("Введите пятизначное число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
    if(number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Введенное число: {number} - палидром");
    }   else 
    Console.WriteLine($"Введенное число: {number} - не палидром");
}
if(number!.Length == 5)
{
    CheckingNumber(number);
}
else
Console.WriteLine($"Введите верное число: ");

//2-ой способ:

// int[] digits = new int[100];
// string? numberstring;
// int miss = 0;

// Console.WriteLine("Введите число, чтобы проверить его на палидромность:");
// numberstring = Console.ReadLine();
// int size = numberstring.Length;
// for (int i = 0; i < size; i++)
// {
//     digits[i] = getdigit(numberstring, i + 1);
// }

// for (int i = 0; i < (size / 2); i++)
// {
//     if ((digits[i]) != (digits[size - i-1]))
//     {
//         miss++;
//     }
// }

// if (miss > 0)
// {
//     Console.WriteLine("Не является палиндром");
// }
// else
// {
//     Console.WriteLine("Палиндром");
// }


// int getdigit(string numba, int count) 
// {
//     int sizenumber = numberstring.Length; 
//     int intnumber = Convert.ToInt32(numba);
//     int doublei = 0;
//     int Digit1 = default;
//     while (doublei < count)
//     {
//         Digit1 = intnumber / Convert.ToInt32(Math.Pow(10, (sizenumber - 1)));         
//         intnumber = intnumber - Digit1 * Convert.ToInt32(Math.Pow(10, (sizenumber - 1)));
//         doublei++;
//         sizenumber--;
//     }
//     return Digit1;
// }