// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.

Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число C");
int numberC = Convert.ToInt32(Console.ReadLine());

bool Triangle(int numA, int numB, int numC)
{
    return (numA < numB + numC && numB < numA + numC && numC < numA + numB);
}

bool triangle = Triangle(numberA, numberB, numberC);
if(triangle) Console.WriteLine("Треугольник со сторонами такой длины может существовать");
else Console.WriteLine("Треугольник со сторонами такой длины не может существовать");