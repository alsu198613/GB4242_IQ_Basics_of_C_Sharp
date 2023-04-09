// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int NumOfEven(int[] array)
{
    int count = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
int num = NumOfEven(array);
Console.WriteLine($"Количество четных чисел = {num}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

int SumOfOddPosition(int[] array)
{
    int sum = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}

Console.WriteLine();
int[] collection = new int[4];
FillArray(collection);
PrintArray(collection);
int sum = SumOfOddPosition(collection);
Console.WriteLine($"сумма элементов на нечётных позициях = {sum}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillDoubleArray(double[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Random rand = new Random();
        array[i] = Math.Round(rand.NextDouble() * 10, 2);
    }
}

void PrintDoubleArray(double [] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double DifferenceMaxMin(double [] array)
{
    int length = array.Length;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }

    double difference = Math.Round(max - min, 2);
    return difference;

}

Console.WriteLine();
double[] double_array = new double[5];
FillDoubleArray(double_array);
PrintDoubleArray(double_array);
double difference = DifferenceMaxMin(double_array);
Console.WriteLine($"разница между максимальным и минимальным элементами массива = {difference}");


