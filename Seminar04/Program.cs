// Задача 24: Напишите программу, которая принимает на вход число (А) и выдает сумму чисел
// 7 -> 278
// 4 -> 10
// 8 -> 36

int SetNumber(string text = "")
{
    Console.WriteLine($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int num = SetNumber();
int sum = 0;
for (int i = 0; i < num; i++)
{
    sum += i;
}

Console.WriteLine("sum = " + sum);

//2 вариант

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

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

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


//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и 
//единицами в случайном порядке.

int[] array = GetRandomArray(8, 0, 1);
Console.WriteLine($"[{String.Join(",", array)}]");


// метод создания массива из случайных чисел
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
