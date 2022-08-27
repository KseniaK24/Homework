// Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
/*
Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1>num2)
{
    Console.Write($"The larger number is {num1}, the smaller number is {num2}");
}
else
 Console.Write($"The larger number is {num2}, the smaller number is {num1}");
*/

// Задача 4. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
/*
Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max)
{
    max = num2;
}
if(num3>max)
{
    max = num3;
}

Console.Write($"Maximum number is {max}");
*/

// Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без остатка).
/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.Write($"Yes, {num} is an even number");
}
else
Console.Write($"No, {num} is odd number");
*/

// Задача 8. Напишите программу, которая на входе принимает число (N), а на выходе показывает все четные числа от 1 до N/
/*
Console.Write("Input integer number: ");
int N = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current <= N)
{
    Console.Write(current + " ");
    current = current + 2;
}
*/
