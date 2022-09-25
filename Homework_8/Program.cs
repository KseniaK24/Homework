// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки
// двумерного массива.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

int[,] SortDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = j; k > 0; k--)
                if (array[i, k] > array[i, k - 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k - 1];
                    array[i, k - 1] = temp;
                }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

int[,] sortArray = SortDescending(newArray);
Show2dArray(sortArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей
// суммой элементов.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

int[] ArraySum(int[,] array)
{
    int[] newArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        newArray[i] = sum;
    }
    return newArray;
}

int NumberMinValue(int[] array)
{
    int min = array[0];
    int number = 0;
    for (int i = 1; i < array.Length; i++)
        if (array[i] < min)
        {
            min = array[i];
            number = i;
        }
    return number;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[,] newAray = CreateRandom2dArray();
Show2dArray(newAray);
int[] arraySum = ArraySum(newAray);
PrintArray(arraySum);
Console.Write($"String with minimum sum value of {NumberMinValue(arraySum) + 1}");
*/

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

int[,] MatrixProduct(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
        for (int j = 0; j < matrixB.GetLength(1); j++)
            for (int k = 0; k < matrixA.GetLength(1); k++)
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
    return (matrixC);
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Enter data 1 of the matrix");
Console.WriteLine();
int[,] matrix1 = CreateRandom2dArray();
Console.Write("Enter data 2 of the matrix");
Console.WriteLine();
int[,] matrix2 = CreateRandom2dArray();

Show2dArray(matrix1);
Show2dArray(matrix2);

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    int[,] matrix3 = MatrixProduct(matrix1, matrix2);
    Show2dArray(matrix3);
}
else
    Console.Write("The product of matrices is impossible");
*/

// Задача 60: Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет
// построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] Create3dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of layer: ");
    int layer = Convert.ToInt32(Console.ReadLine());

    int[,,] newArray = new int[rows, columns, layer];
    int temp = 10;
    for (int k = 0; k < layer; k++)
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
            {
                newArray[i, j, k] = temp;
                temp += 1;
            }
    return newArray;
}

void Show3dArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j, k]);
                Console.Write($"({i},{j},{k})" + " ");
            }
            Console.WriteLine();
        }
    Console.WriteLine();
}

int[,,] newArray = Create3dArray();

Show3dArray(newArray);
*/

// Задача 62: Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int[,] SpirallyFilledArray(int size)
{
    int[,] array = new int[size, size];
    int temp = 10;
    for (int m = 0, n = array.GetLength(0) - 1; n >= 0; n--, m++)
    {
        for (int i = m, j = m; j <= n; j++)
        {
            array[i, j] = temp;
            temp++;
        }
        for (int j = n, i = m + 1; i <= n; i++)
        {
            array[i, j] = temp;
            temp++;
        }
        for (int i = n, j = n - 1; j >= m; j--)
        {
            array[i, j] = temp;
            temp++;
        }
        for (int j = m, i = n - 1; i >= m + 1; i--)
        {
            array[i, j] = temp;
            temp++;
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] spirallyArray = SpirallyFilledArray(size);

Show2dArray(spirallyArray);
*/