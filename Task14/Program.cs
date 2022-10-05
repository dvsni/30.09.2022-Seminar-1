// Напишите программу, которая
// принимает на вход число
// и проверяет, кратно ли оно одновременно 7 и 23
// 14->нет
// 46->нет
// 161->да

bool CheckingNumber(int number, int div1, int div2)
{
    return number % div1 == 0 && number % div2 == 0;
}


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = CheckingNumber(num, 7, 23);
if(result)
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");
