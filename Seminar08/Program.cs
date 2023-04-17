// https://gist.github.com/dc60007dbf9ebd20ffad4029fdea6410.git

// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
int rows = SetNumber("rows");
int columns = SetNumber("columns");

int[,] matrix = GetRandomMatrix(rows, columns, 0, 10);
PrintMatrix(matrix);
int[,] newMatrix = GenerateNew(matrix);
Console.WriteLine();
PrintMatrix(newMatrix);

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

int[,] GenerateNew(int[,] matrix)
{
    int temp = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }

    return matrix;
}
// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int rows2 = SetNumber("rows");
int columns2 = SetNumber("columns");

int[,] matrix2 = GetRandomMatrix(rows2, columns2, 0, 10);
PrintMatrix(matrix2);
int[,] newMatrix2 = GenerateNew2(matrix2);
Console.WriteLine();
PrintMatrix(newMatrix2);

int[,] GenerateNew2(int[,] array)
{
    int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[j, i] = array[i, j];
        }
    }
    return newArray;
}
