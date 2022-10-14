// Напишите программу, 
// которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//1-ый способ:

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


// // 2-ой способ:

// string[,] coordinates = new string[4, 4];
// double dist = default;
// coordinates[0, 1] = "X";
// coordinates[0, 2] = "Y";
// coordinates[0, 3] = "Z";

// coordinates[1, 0] = "A";
// coordinates[2, 0] = "B";
// coordinates[3, 0] = "temp";

// for (int i = 1; i < 3; i++)
// {
//     Console.WriteLine($"Введите Координаты точки {coordinates[i, 0]} :");
//     for (int j = 1; j < 4; j++)
//     {
//         Console.WriteLine($"Введите Координату {coordinates[0, j]} точки {coordinates[i, 0]}: ");
//          coordinates[i, j] = Console.ReadLine();
//     }
// }

// for (int j = 1; j < 4; j++)
// {
//     coordinates[3, j] = Convert.ToString(raznsqr(Convert.ToDouble(coordinates[2, j]), Convert.ToDouble(coordinates[1, j])));
// }

// dist = Math.Round(distance(coordinates[3, 1], coordinates[3, 2], coordinates[3, 3]),2);
// Console.WriteLine($"Расстояние между точками = {Convert.ToString(dist)}");

// double distance(string x, string y, string z)
// {
//     double x1= Convert.ToDouble(x);
//     double y1= Convert.ToDouble(y);
//     double z1= Convert.ToDouble(z);

//     double d = Math.Sqrt(x1 + y1 + z1);
//     return d;
// }

// double raznsqr(double a, double b)
// {
//     double razn = sqr(Convert.ToInt32( b )- Convert.ToInt32( a));
//     return razn;
// }

// int sqr(int num)
// {
//     int sqr = num * num;
//     return sqr;
// }