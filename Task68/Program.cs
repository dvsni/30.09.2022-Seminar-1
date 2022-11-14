// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите первое число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число n: ");
int n = Convert.ToInt32(Console.ReadLine());

FunctionAkkerman(m,n);

void FunctionAkkerman(int m, int n)
{
    Console.Write(FunctAkk(m,n));
}

int FunctAkk (int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(n == 0 && m > 0)
    {
        return FunctAkk(m - 1, 1);
    }
    else
    {
        return(FunctAkk(m - 1, FunctAkk(m, n - 1)));
    }
}

