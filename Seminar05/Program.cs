/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.*/

// int size = 12;
// int[] nums = GetArray(size);
// Console.WriteLine(string.Join("; ", nums));

int[] array = GetRandomArray(12, -9, 9);
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

int SumNumPlus(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result = result + array[i];
        }
    }
    return result;
}

int SumNumMin(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            result = result + array[i];
        }
    }
    return result;
}

Console.WriteLine($"Сумма положительных чисел: {SumNumPlus(array)}");
Console.WriteLine($"Сумма отрицательных чисел: {SumNumMin(array)}");

/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

int[] startArray = GetRandomArray(6, -10, 10);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine(String.Join(" ", InversArray(startArray)));

int[] InversArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}


/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/

int[] array3 = GetRandomArray(5, -100, 100);
Console.WriteLine($"Случайный массив 3 [{String.Join(", ", array3)}]");

Console.Write("Enter a number to find: ");
int n = int.Parse(Console.ReadLine());

if (FindElement(array3, n))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


bool FindElement(int[] array, int num)
{
    foreach (var item in array)
    {
        if (item == num) return true;
    }
    return false;
}

/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат 
в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2]-> 0
[10, 11, 12, 13, 14]-> 5 */

// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }

//     return result;
// }

int[] array2 = GetRandomArray(5, -100, 150);
Console.WriteLine($"Случайный массив 2 [{String.Join(", ", array2)}]");

int count = GetCount(array2, 10, 99);

int GetCount(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine($"Количество чисел в заданном интервале: {count}");

/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6]-> 36 21 */

int[] array4 = GetRandomArray(5, 0, 10);
Console.WriteLine($"Случайный массив 4 [{String.Join(", ", array4)}]");

int[] mult = ResultArray(array4);

int[] ResultArray(int[] array)
{
    int size = array.Length / 2;
    //int size = array.Length % 2 == 0 ? array.Length / 2 : (array.Length / 2) + 1;

    if (array.Length % 2 == 1) size++;

    int[] result = new int[size];

    for (int i = 0; i < array.Length / 2; i++)
    {

        result[i] = array[i] * array[array.Length - 1 - i];
    }

    if (array.Length % 2 == 1) result[size - 1] = array[array.Length / 2];

    return result;
}
Console.WriteLine($"Новый случайный массив 4 [{String.Join(", ", mult)}]");
