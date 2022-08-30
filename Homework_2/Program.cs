// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit (int num)
{
    int a, b, res;
    a = num % 100;
    b = num % 10;
    res = (a-b)/10;
    return res;
}

Console.WriteLine("Enter three-digit number");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondDigit(number);

Console.WriteLine($"From number {number} the second digit {result}");
*/

// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdNumber(int num)
{
    while(num>999)
    {
    num = num / 10;
    }
    int res = num % 10;
    return res;
}

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());

if (number>99)
{
int result = ThirdNumber(number);
Console.WriteLine($"From number {number} the third digit {result}");
}
else
Console.WriteLine($"{number} has no third digit");
*/

// Задача 15. Напишите программу,которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool CheckDay (int num)
{
    int a = 6;
    int b = 7;
    if ((num == a) | (num == b))
    return true;
    return false;
}

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());

bool result = CheckDay(number);

if(result)
    Console.WriteLine("Yes, it's a day off");
else
   Console.WriteLine("No, it's no a day off"); 
*/