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