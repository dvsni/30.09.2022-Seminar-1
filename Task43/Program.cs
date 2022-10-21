// Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Функция прямой 1: y = k1*x + b1");
System.Console.Write("Введите b1: ");
int b1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
int k1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("Функция прямой 2: y = k2*x + b2");
Console.Write("Введите b2: ");
int b2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Точка пересечения: ");
if (k1==k2)
{
  Console.Write("Не существует, потому что параллельны прямые.");  
}
else
{
    Console.Write($"X = {ArrCrossLineX(k1,b1,k2,b2)}, Y = {ArrCrossLineY(ArrCrossLineX(k1,b1,k2,b2),k1,b1)}");
}


double ArrCrossLineX (int k1, int b1,int k2,int b2)
{
var x=(double)(b2-b1)/(k1-k2);
return x;
}

double ArrCrossLineY (double x, int k,int b)
{
var y =(double) k*x + b;
return y;
}