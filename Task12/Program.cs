// Напишите программу, которая
// будет принимать на выход два числа
// и выводить является ли второе число кратным первому
// Если число 2 не кратно числу 1, то программа выводит остаток от деления
// 34,5-> не кратно, остаток 4
// 16,4-> кратно


Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int remains = a % b;

//  if (number == 0)
//  {
//     Console.WriteLine("Кратно");
//  }
// else Console.WriteLine($"Не кратно {a % b}");

bool Multiplicity(int number_A, int number_B)
{
    bool Flag = default;
    int res = number_A % number_B;
    if (res == 0) Flag = true;
    else Flag = false;
    return Flag;
}

 if (Flag == true)
 {
    Console.WriteLine("Кратно");
 }
else Console.WriteLine($"Не кратно, {(remains)}");
