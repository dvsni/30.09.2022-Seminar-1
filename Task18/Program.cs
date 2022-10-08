// Напишите программу,
// которая по заданному номеру четверти,
// показывает диапазон возможных координат точек
// в этой четверти (x и y)
// int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер четверти: ");
string number = Console.ReadLine();

string result = Range(number);
Console.WriteLine(result);

string Range(string number)
{
    if (number == "1") return "x > 0 и y > 0";
    if (number == "2") return "x < 0 и y > 0";
    if (number == "3") return "x < 0 и y < 0";
    if (number == "4") return "x > 0 и y < 0";
    return "Ошибка ввода";
}