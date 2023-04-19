// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = SetNumber("rows");
int columns = SetNumber("columns");
int[,] matrix = GetRandomMatrix(rows, columns, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[,] matrixSorted = GetRowSort(matrix);
PrintMatrix(matrixSorted);


int SetNumber(string text = "")
{
    Console.WriteLine($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

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

int[,] GetRowSort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] < matrix[i, k])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }

        }
    }
    return matrix;
}


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

int rows2 = SetNumber("rows");
int columns2 = SetNumber("columns");
int[,] matrix2 = GetRandomMatrix(rows2, columns2, 0, 10);
PrintMatrix(matrix2);
Console.WriteLine();
GetMinSumRow(matrix2);

void GetMinSumRow(int[,] matrix)
{
    int minSum = int.MaxValue;
    int minRowSum = 0;
    int sum = 0;
    int indexRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];

        }

        if (sum < minSum)
        {
            minSum = sum;
            indexRow = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {indexRow + 1}");
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
// двух матриц. Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rowsM1 = SetNumber("rows");
int columnsM1 = SetNumber("columns");
int rowsM2 = SetNumber("rows");
int columnsM2 = SetNumber("columns");

if (columnsM1 != rowsM2)
{
    Console.WriteLine("Невозможно умножить матрицы");
    return;
}

int[,] matrixM1 = GetRandomMatrix(rowsM1, columnsM1, 0, 10);
PrintMatrix(matrixM1);
Console.WriteLine();

int[,] matrixM2 = GetRandomMatrix(rowsM2, columnsM2, 0, 10);
PrintMatrix(matrixM2);
Console.WriteLine();
int[,] multMatrix = GetMultMatrix(matrixM1, matrixM2);
PrintMatrix(multMatrix);

int[,] GetMultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(0); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = sum;
        }
    }
    return result;
}


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)
int x = SetNumber("x");
int y = SetNumber("y");
int z = SetNumber("z");

int[,,] array3D = Get3DArray(x, y, z);
Print3DArray(array3D);

int[,,] Get3DArray(int x, int y, int z)
{
    int[,,] arr = new int[x, y, z];
    int num = 10;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = num;
                num++;
            }
        }
    }
    return arr;
}
void Print3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + "(" + i + "," + j + "," + k + ") ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}

// Задача 62.Напишите программу, которая заполнит спирально массив . Размер вводит юзер
// Например, на выходе получается вот такой массив:

// Задача 62.Напишите программу, которая заполнит спирально массив . Размер вводит юзер
// Например, на выходе получается вот такой массив:


int rowsN = SetNumber("rows");
int columnsN = SetNumber("columns");

int[,] spiralMatrix = FillArraySpiral(rowsN, columnsN); 

PrintMatrix(spiralMatrix);


int[,] FillArraySpiral(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int num = 1;
    int maxRow = rows - 1;
    int maxCol = columns - 1;
    int minRow = 0;
    int minCol = 0;

    while (num <= rows * columns)
    {
        // заполнение верхней строки
        for (int i = minCol; i <= maxCol; i++)
        {
            array[minRow, i] = num;
            num++;
        }
        minRow++;

        // заполнение правого столбца
        for (int i = minRow; i <= maxRow; i++)
        {
            array[i, maxCol] = num;
            num++;
        }
        maxCol--;

        // заполнение нижней строки
        for (int i = maxCol; i >= minCol; i--)
        {
            array[maxRow, i] = num;
            num++;
        }
        maxRow--;

        // заполнение левого столбца
        for (int i = maxRow; i >= minRow; i--)
        {
            array[i, minCol] = num;
            num++;
        }
        minCol++;
    }
    return array;
}


