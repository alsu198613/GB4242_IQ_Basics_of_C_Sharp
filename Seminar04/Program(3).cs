// Напишите программу, которая принимает на вход число A
// и выдаёт сумму чисел от 1 до A

Console.Write("Введите число: ");
int limit = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {limit} равна {GetSum(limit)}");

int GetSum(int limit)
{
    int sum = 0;

    for (int i = 1; i <= limit; i++)
        sum += i;

    return sum;
}


//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int rank = int.Parse(Console.ReadLine());

Console.WriteLine($"{num} в степени {rank} = {Pow(A, rank)}");


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


//Напишите программу, которая принимает 
//на вход число N и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Суммф цифр = {GetSumNums(num)}");


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


//Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.
Console.Clear();
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

void GetRandomArrayFor(int[] arr)
{
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine($"{arr[i]} ,");
    }
}

void GetRandomArrayForeach(int[] arr)
{ 
    foreach (var item in arr)
    {
        System.Console.WriteLine($"{item} ,");
    }
}
// // Задача 24: Напишите программу, 
// // которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// // 7 -> 28
// // 4 -> 10
// // 8 -> 36

// int SetNumber(string text = "")
// {
//     Console.Write($"Enter number {text}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int num = SetNumber();
// int sum = 0;
// for (int i = 1; i <= num; ++i)
// {
//     sum += i;
// }

// System.Console.WriteLine("sum = " + sum);

int a = 40;

int b = 30; // b = 40 a = 41
int c = a + b;
System.Console.WriteLine($"a= {a} b={b}");
bool Task21()
{
    Console.Write("\nВведите координаты первой точки (разделитель - пробел): ");
    double[] point1 = Console.ReadLine().Split(' ').Select(x => Convert.ToDouble(x)).ToArray();
    Console.Write("\nВведите координаты второй точки (разделитель - пробел): ");
    double[] point2 = Console.ReadLine()!.Split(' ').Select(x => Convert.ToDouble(x)).ToArray();
    Console.WriteLine($"D = {Math.Sqrt(point1.Zip(point2, (first, second) => Math.Pow(first - second, 2)).Sum())}");
    return true;
}