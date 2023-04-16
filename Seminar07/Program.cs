//Задача 46: Задать двумерный массив m x n , заполненный случайными целыми числами

int rows = SetNumber("rows");
int columns = SetNumber("columns");

int[,] matrix = GetRandomMatrix(rows, columns, 10, 99);
PrintMatrix(matrix);

int SetNumber(string numberName)
{
Console.Write($"Enter number {numberName}: ");
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

/* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m + n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */


Start();

void Start()
{
    int rows = SetNumber("rows");
    int columns = SetNumber("columns");

    int[,] matrix = GetMatrix(rows, columns, 0, 10);
    PrintMatrix(matrix);
}

// int SetNumber(string numberName)
// {
//     Console.Write($"Enter number {numberName}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];

    var rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }

    return array;
}

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }

// }


/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти 
элементы на их квадраты.
 */

int rows2 = SetNumber("rows");
int columns2 = SetNumber("columns");

int[,] matrix2 = GetRandomMatrix(rows2, columns2, 0, 10);
PrintMatrix(matrix2);
Console.WriteLine();
int[,] array2 = ChangeMatrix(matrix2);
PrintMatrix(array2);



// int SetNumber(string numberName)
// {
//     Console.Write($"Enter number {numberName}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int[,] GetRandomMatrix(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows, columns];

//     var rand = new Random();

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = rand.Next(min, max + 1);
//         }
//     }

//     return array;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }

// }

int[,] ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }

        }
    }

    return matrix;
}

/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д.*/

Start3();

void Start3()
{
    int rows3 = SetNumber("rows");
    int columns3 = SetNumber("columns");

    int[,] matrix3 = GetRandomMatrix(rows3, columns3, 0, 10);
    PrintMatrix(matrix3);

    int result = GetDiagonalSum(matrix3);
    Console.WriteLine($"Сумма элементов главной диагонали = {result}");
}


// int SetNumber(string numberName)
// {
//     Console.Write($"Enter number {numberName}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int[,] GetRandomMatrix(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows, columns];

//     var rand = new Random();

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = rand.Next(min, max + 1);
//         }
//     }

//     return array;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }

// }

int GetDiagonalSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matrix[i,j];
            }

        }
    }

    return sum;
}