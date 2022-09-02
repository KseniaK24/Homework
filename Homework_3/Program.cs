// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void NumbersCheck (int num)
{
int digit1 = num / 10000;
int digit2 = num % 10000 / 1000;
int digit3 = num % 1000 / 100;
int digit4 = num % 100 / 10;
int digit5 = num % 10;
if(digit1 == digit5 && digit2 == digit4)
Console.Write($"Yes, {num} this number is a palindrome");
else
Console.Write($"No, {num} this number is not a palindrome");
}

Console.Write("Enter a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

NumbersCheck(number);
*/
// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 
// в 3D пространстве.
/*
double DistanceBetweenPoints (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dx = x2-x1;
    double dy = y2-y1;
    double dz = z2-z1;
    double dist = Math.Sqrt(dx*dx + dy*dy + dz*dz);
    return dist;
}

Console.Write("Enter X coordinate of 1 point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Y coordinate of 1 point: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Z coordinate of 1 point: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter X coordinate of 2 point: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Y coordinate of 2 point: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Z coordinate of 2 point: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double Distance = DistanceBetweenPoints(x1, y1, z1, x2, y2, z2);
Console.Write($"The distance between the points ({x1},{y1},{z1}) and ({x2},{y2},{z2}) is {Distance}");
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
/*
void CubeTable (int n)
{
    int i = 1;
    while (i <= n)
{
    double cube = Math.Pow(i,3);
    Console.WriteLine($"{cube}, ");
    i++;
}
}
Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

CubeTable(number);
*/