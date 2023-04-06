/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16 */

Console.WriteLine("Enter number A: ");
Console.WriteLine("Enter number B: ");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int result = 1;

for (int i = 1; i <= numberB; i++)
{
    result = result * numberA;
}

Console.WriteLine(result);


/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 0; num > 0; i++)
{
    sum += num % 10;
    num /= 10;
}

Console.WriteLine(sum);

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33-> [6, 1, 33] */

Console.WriteLine(("Введите длинну массива: "));
int arrayLength = int.Parse(Console.ReadLine());

int[] randomArray = new int[arrayLength];
for (int i = 0; i < arrayLength; i++)
{
    randomArray[i] = new Random().Next(1, 9);
    Console.Write(randomArray[i] + " ");
}
