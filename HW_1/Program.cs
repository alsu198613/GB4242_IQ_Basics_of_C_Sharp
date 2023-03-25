/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7->max = 7
a = 2 b = 10->max = 10
a = -9 b = -3->max = -3
*/

Console.WriteLine("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"max = {num1}");
}
else
{
    Console.WriteLine($"max = {num2}");
}


/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Enter first number: ");
int num_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int num_2 = int.Parse(Console.ReadLine());
int num_3 = int.Parse(Console.ReadLine());
int max;

if (num_1 > num_2)
{
    max = num_1;
}
else
{
    max = num_2;
}
if (num_3 > max)
{
    max = num_3;
}

Console.WriteLine(max);


/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}


/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i < num + 1; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}









