//метод ввода числа от пользователя

int numb = SetNumber();
Console.WriteLine(numb);

int SetNumber(string text = "")
{
    Console.WriteLine($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// метод создания массива из случайных чисел

int[] array = GetRandomArray(8, 0, 100);
Console.WriteLine($"Случайный массив [{String.Join(", ", array)}]");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

// вывод массива на печать
Console.WriteLine($"[{String.Join(", ", array)}]");

// 2 вариант
Console.WriteLine("вывод массива на печать - 2 вариант");
PrintArrayFor(array);

void PrintArrayFor(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}
// 3 вариант

Console.WriteLine("вывод массива на печать - 3 вариант");
PrintArrayForeach(array);

void PrintArrayForeach(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item}, ");
    }
    Console.WriteLine();
}

//4 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.WriteLine(array[i]);
        else Console.Write($"{array[i]}, ");
    }
}

//метод создания двумерного массива из случайных чисел и его печать
int[,] matrix = GetRandomMatrix(rows, columns, 0, 10);
PrintMatrix(matrix);

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

//метод создания двумерного массива из случайных вещественных чисел и его печать

double[,] matrix = GetRandDblMatrix(rows, columns, -100, 100);
PrintDblMatrix(matrix);

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
            Console.Write($"{matrix[i, j]:f2} ");
        }
        Console.WriteLine();
    }
}