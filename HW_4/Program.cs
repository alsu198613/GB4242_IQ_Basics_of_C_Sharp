/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16 */

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int rank = int.Parse(Console.ReadLine());

Console.WriteLine($"{num} в степени {rank} = {Pow(num, rank)}");


int Pow(int num, int rank)
{
    if (rank == 0) return 1;
    else if (rank == 1) return num;
    else if (num == 0 || num == 1) return num;

    int result = num;
    for (int i = 2; i <= rank; i++)
    {
        result *= num;
    }
    return result;
}


/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Суммф цифр = {GetSumNums(number)}");


int GetSumNums(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33-> [6, 1, 33] */

int[] array = GetRandomArray(8, 0, 100);
Console.WriteLine($"[{String.Join(",", array)}]");


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}
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
