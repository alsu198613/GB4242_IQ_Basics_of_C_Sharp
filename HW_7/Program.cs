// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int rows = SetNumber("rows");
int columns = SetNumber("columns");

double[,] matrix = GetRandDblMatrix(rows, columns, -100, 100);
PrintDblMatrix(matrix);

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double[,] GetRandDblMatrix(int rows, int columns, int min, int max)
{
    double[,] array = new double[rows, columns];

    var rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Convert.ToDouble(rand.Next(min, max + 1)) / 10;
        }
    }

    return array;
}

void PrintDblMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]:f2} ");
        }
        System.Console.WriteLine();
    }
}
// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном 
// массиве, и возвращает его индексы первого найденого числа или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

int rows2 = SetNumber("rows");
int columns2 = SetNumber("columns");

int[,] matrix2 = GetRandomMatrix(rows2, columns2, -100, 100);
PrintMatrix(matrix2);
FindNumInMatrix(matrix2, 1, 4);

int[,] GetRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];

    var rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }

    return array;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FindNumInMatrix(int [,] array, int m, int n)
{
    if (m > array.GetLength(0) || n > array.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"значение элемента {m} строки и {n} столбца равно {array[m - 1, n - 1]}");
    }
}


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows3 = SetNumber("rows");
int columns3 = SetNumber("columns");

int[,] matrix3 = GetRandomMatrix(rows3, columns3, 0, 10);
PrintMatrix(matrix3);
double[] matrixAvg = AvgColMatrix(matrix3);
Console.WriteLine($"[{String.Join("; ", matrixAvg)}]");
//FindNumInMatrix(matrix2, 1, 4);

double [] AvgColMatrix(int[,] array)
{
    double sum = 0;
    double [] avgCol = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j,i];

        }
        avgCol[i] = sum / array.GetLength(0);
        sum = 0;
    }
    return avgCol;
}