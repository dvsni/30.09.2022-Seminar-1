// Напишите программу, 
// которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты x точки А");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y точки А");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z точки А");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты x точки B");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y точки B");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z точки B");
int zb = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Distance(xa, ya, xb, yb, za, zb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние от точки A до точки B: {distance}");

double Distance(int x1, int y1, int x2, int y2, int z1, int z2)
{
    double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + + Math.Pow((z2 - z1), 2));
    return dist;
}


Math.Sqrt(125);
Math.Pow(2, 10); //2 в степени 10