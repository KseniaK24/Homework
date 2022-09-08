// Задача 25: Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную
// степень В.
/*
int Exponentiation (int a, int b)
{
    int result = 1;
    for(int i = 1; i <= b; i++)
    result *= a;
return result;
}

Console.Write("Enter a number A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write($"The number {num1} a to the power of {num2} is equal to {Exponentiation(num1, num2)}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
/*
int NumberDigits( int num)
{
    int result = 0;
   while(num>0)
   {
        num/=10;
        result++;
   }
   return result;
}

int SumDigits(int num)
{
int sum = 0;
int digit = 0;
int k = 10;
int n = 1;
int count = NumberDigits(num);
for(int i=1; i<=count; i++)
{
    digit = num % k / n;
    sum += digit;
    k *= 10;
    n *= 10;
}
return sum;
}

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumDigits(number);

Console.Write($"The sum of the digits of {number} is equal to {result}");
*/

// Задача 29: Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
/*
int [] Array (int n)
{
    int [] arr = new int[n];
    for(int i = 0; i < n; i++)
    {
        Console.Write("Enter an array element: ");
        arr [i]= Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int [] arr)
{
    Console.Write("[");
    for(int i = 0; i<arr.Length; i++)
    Console.Write($"{arr[i]}, ");
    Console.Write("]");
}

int [] newArr = Array(8);

PrintArray(newArr);
*/