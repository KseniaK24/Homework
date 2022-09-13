// Задача 41: Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.
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

int PositiveNumbers(int [] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
        if(array[i]>0)
            count++;
    return count;
}

void PrintArray(int [] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}   

Console.Write("Enter the number of numbers: ");
int num = Convert.ToInt32(Console.ReadLine());

int [] newArray = Array(num);

PrintArray(newArray);
Console.Write($"Positive numbers {PositiveNumbers(newArray)}");
*/

// Задача 43: Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениеми y=k1*x+b1,
// y=k2*x+b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
double [] IntersectionPoint (double b1, double k1, double b2, double k2)
{
    int size = 2;
    double [] array = new double [size];
    array[0] = (b2-b1)/(k1-k2);
    array[1] = k1*array[0]+b1;
    return array;
}

void PrintArray(double [] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}   

Console.Write("Enter b1:  ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k1:  ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2:  ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2:  ");
double k2 = Convert.ToDouble(Console.ReadLine());

double [] result = IntersectionPoint(b1, k1, b2, k2);

PrintArray(result);
*/

