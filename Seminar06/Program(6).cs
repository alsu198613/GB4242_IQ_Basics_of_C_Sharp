
//Универсальный математический для перевода из 10 в любую
string DecToNum(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        int ost = decNumber / otherSystem;
        res = nums[decNumber - (otherSystem * ost)] + res;
        decNumber /= otherSystem;
    }
    return res;
}

//Напишите программу, 
//которая будет преобразовывать десятичное число в двоичное.

Console.Clear();
int number = int.Parse(Console.ReadLine());

string res1 = Convert.ToString(number, 2);
string res2 = DecToNum(number, 2);

Console.WriteLine($"{number}->{res1}");
Console.WriteLine($"{number}->{res2}");


string DecToNum1(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        int ost = decNumber / otherSystem;
        res = nums[decNumber - (otherSystem * ost)] + res;
        decNumber /= otherSystem;
    }
    return res;
}


// Задача 39: Напишите программу, 
//которая перевернёт одномерный массив (последний элемент будет на первом месте,
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
string BinaryCode = Convert.ToString(800, 5);
System.Console.WriteLine(BinaryCode);
Console.ReadLine();
int[] array = GetRandomArray(12, 0, 100);
Console.WriteLine($"[{String.Join(",", array)}]");
MyReverse2(array);
Console.WriteLine($"[{String.Join(",", array)}]");

void MyReverse2(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }

}

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
