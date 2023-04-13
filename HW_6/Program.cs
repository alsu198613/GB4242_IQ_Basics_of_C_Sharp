/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
 */
Console.Write("Enter number of elements: ");
int M = int.Parse(Console.ReadLine());
int[] numbers = new int[M];

FillArrayWithM(numbers);
PrintArray(numbers);
int numberOfPositive = CountOfPositive(numbers);
Console.WriteLine(numberOfPositive);

void FillArrayWithM(int[] array)
{
    for (int i = 0; i < M; i++)
    {
        Console.Write($"Enter element {i + 1}: ");
        numbers[i] = int.Parse(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.WriteLine(array[i]);
        else Console.Write($"{array[i]}, ");
    }
}

int CountOfPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}


/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5) */