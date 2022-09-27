// Задача 64: Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNums(int n, int m)
{
    if (m > n)
    {
        int k = m;
        m = n;
        n = k;
    }
    if (n > m) ShowNums(n - 1, m);
    Console.Write(n + " ");
}

Console.Write("Enter a value N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a value M: ");
int m = Convert.ToInt32(Console.ReadLine());

ShowNums(n, m);
*/

// Задача 66: Задайте значение M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.
/*
int SumNaturalNumbers(int n, int m)
{
    if (m > n) return m + SumNaturalNumbers(n, m - 1);
    if (n > m) return n + SumNaturalNumbers(n - 1, m);
    else return n;
}

Console.Write("Enter a value N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a value M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write(SumNaturalNumbers(n, m));
*/

// Задача 68: Напишите программу, вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int FunctionAckerman(int m, int n)
{
    if (m == 0) return n + 1;
    if ((m > 0) && (n == 0)) return FunctionAckerman(m - 1, 1);
    if ((m > 0) && (n > 0)) return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
    return n+1;
}

Console.Write("Enter a value M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a value N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(FunctionAckerman(m, n));
