// Задача 39: Напишите программу, 
//которая перевернёт одномерный массив (последний элемент будет на первом месте,
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
/*
Console.Clear();
int[] array = GetRandomArray(12, 0, 100);
Console.WriteLine($"[{String.Join(",", array)}]");
array = MyReverse1(array);
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

int[] MyReverse1(int[] array)
{
    int[] reverse = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        reverse[i] = array[array.Length - 1 - i];
    }

    return reverse;
}


/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. */

/*
Console.WriteLine("Enter sides of triangle ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

IsTriangle(a, b, c);


void IsTriangle(int a, int b, int c)
{

    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("Triangle exists");
    }
    else {
        Console.WriteLine("Triangle doesn't exist");
    };
}
*/
/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
 */

static void DecimalToBinary()
{
    Console.Write("Введите десятичное число: ");
    int decimalNumber = int.Parse(Console.ReadLine());

    string binaryNumber = "";

    while (decimalNumber > 0)
    {
        int remainder = decimalNumber % 2;
        binaryNumber = remainder + binaryNumber;
        decimalNumber /= 2;
    }

    Console.WriteLine("Двоичное число: " + binaryNumber);
}

DecimalToBinary();