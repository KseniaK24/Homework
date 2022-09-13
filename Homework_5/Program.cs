// Задача 34: Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, 
//которая покажет количество четных чисел в массиве.
/*
int [] CreateRandomArray(int size)
{
    int [] arr = new int [size];
    for(int i=0; i<size; i++)
        arr [i]= new Random().Next(100, 1000);
    return arr;
}

int CountEventNumbers(int [] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
        if(array[i] % 2 ==0)
        count++;
    return count;
}

void PrintArray(int [] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateRandomArray(size);
int count = CountEventNumbers(newArray);

PrintArray(newArray);
Console.Write($"There ara {count} even numbers in the array");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих
// на нечетных позициях.
/*
int [] CreateRandomArray(int size, int minVal, int maxVal)
{
    int [] arr = new int [size];
    for(int i=0; i<size; i++)
        arr [i]= new Random().Next(minVal, maxVal+1);
    return arr;
}

int SumOddPositions(int [] array)
{
    int sum=0;
    for(int i=1; i<array.Length; i+=2)
        sum += array[i];
    return sum;
}

void PrintArray(int [] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateRandomArray(size, min, max);
int sum = SumOddPositions(newArray);

PrintArray(newArray);
Console.Write($"The sum of the elements of odd positions is {sum}");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива
/*
double [] CreateRandomArray( int size, int minVal, int maxVal)
{
    double [] arr = new double [size];
    for(int i=0; i<arr.Length; i++)
        arr [i]= new Random().Next(minVal, maxVal) + new Random().NextDouble();
    return arr;
}

double MaxNumber(double [] array)
{
    double max=array[0];
    for(int i=1; i<array.Length; i++)
        if(array[i]> max)
            max = array[i];
    return max;
}

double MinNumber(double [] array)
{
    double min=array[0];
    for(int i=1; i<array.Length; i++)
        if(array[i]< min)
            min = array[i];
    return min;
}

void PrintArray(double [] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double [] newArray = CreateRandomArray(size, min, max);
double result = MaxNumber(newArray)-MinNumber(newArray);
PrintArray(newArray);
Console.Write($"The difference between the maximum and minimum is {result}");
*/
 
