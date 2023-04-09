// Задача 1 
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
/* 
456-> 46
782-> 72
918-> 98 */

int num = new Random().Next(100, 1000);
System.Console.WriteLine(num);

int num1 = num / 100;
int num2 = num / 10;
int num3 = num % 10;
int result = num1*10 + num3;

System.Console.WriteLine(result);

/*Задача 2
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно */

System.Console.WriteLine("enter first number: ");
int num_1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("enter second number: ");
int num_2 = int.Parse(Console.ReadLine());
int num_3 = num_2 % num_1;
if (num_3 == 0) 
{ 
    System.Console.WriteLine("Кратно");
}
else 
{
    System.Console.WriteLine($"не кратно, остаток {num_3}");
 }

/* Задача 4
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да */

System.Console.WriteLine("enter first number: ");
int first_num = int.Parse(Console.ReadLine());

if (first_num % 7 == 0 && first_num % 23 == 0)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}
/*Задача 5
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет */

System.Console.WriteLine("enter first number: ");
int num_one = int.Parse(Console.ReadLine());
System.Console.WriteLine("enter second number: ");
int num_two = int.Parse(Console.ReadLine());

if (num_one == Math.Pow(num_two, 2) || num_two == Math.Pow(num_one, 2)) 
{
    System.Console.WriteLine("да");
 }
else 
{
    System.Console.WriteLine("нет");
 }