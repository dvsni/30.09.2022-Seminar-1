// Напишите программу, которая
// принимает на вход число (N) и
// выдает таблицу квадратов числе от 1 до N
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

//1 метод:
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

while(count <= number)
{
    Console.WriteLine(Square(count));
    count++;
}


string Square(int number)
{
    return ($"{number} -> {number*number}");
}


//2 метод:
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Square(number);

// void Square(int number)
// {
//     int count = 1;
//     while (count <= number)
//     {
//         int square = count*count;
//         Console.WriteLine(${count} {square});
//         count++;
//     }
// }

//3 метод:
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// SquareTable(number);

// void SquareTable(int number)
// {
//     int index = 1;
//     Console.WriteLine($"Таблица квадратов чисел от 1 до {number}");
//     while (index <= number)
//     {
//         Console.WriteLine($"|\t{index, 4}|\t{Math.Pow(index, 2)}\t|");
//         index++;
//     }
// }