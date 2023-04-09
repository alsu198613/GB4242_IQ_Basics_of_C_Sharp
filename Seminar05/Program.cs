/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.*/

int size = 12;
int[] nums = GetArray(size);
Console.WriteLine(string.Join("; ", nums));

int[] GetArray(int size)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        result[i] = rnd.Next(-9, 10);

    return result;
}

int SumNumPlus(int[] array)
{
    int result = 0;
    for (int i = 0; i < size; i++)
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
    for (int i = 0; i < size; i++)
    {
        if (array[i] < 0)
        {
            result = result + array[i];
        }
    }
    return result;
}

Console.WriteLine($"Сумма положительных чисел: {SumNumPlus(nums)}");
Console.WriteLine($"Сумма отрицательных чисел: {SumNumMin(nums)}");


/*int[] array = new int[12];
int size = array.Length;

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();
    
    for (int i = 0; i < size; i++)
    {
    array[i] = rand.Next(min,max +1);
    }
    return array;
}

FillArray(12, -9, 9);

int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < size; i++) 
{
    if (array[i] > 0)
    {
        sumPositive += array[i];
    }
    else
    {
        sumNegative += array[i];
    }
}

for (int i = 0; i < size; i++)
{ 
    Console.Write($"{array[i]}, ");
}
Console.WriteLine();

Console.WriteLine($"сумма положительных чисел равна {sumPositive}");
Console.WriteLine($"сумма отрицательных чисел равна {sumNegative}");*/

/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/

/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат 
в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2]-> 0
[10, 11, 12, 13, 14]-> 5 */

int size = 5;
int[] nums = GetArray(size);
Console.WriteLine(string.Join("; ", nums));

int[] GetArray(int size)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        result[i] = rnd.Next(-9, 10);

    return result;
}




/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6]-> 36 21 */
