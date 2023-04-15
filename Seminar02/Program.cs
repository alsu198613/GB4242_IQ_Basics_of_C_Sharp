// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random().Next(10, 100); // генератор случ.числа, правая граница не включается

int num1 = num / 10;
int num2 = num % 10;

Console.WriteLine(num);

if (num1 > num2)
{
    Console.WriteLine($"num1 > num2 max = {num1} ");
}
else if (num1 < num2)
{
    Console.WriteLine($"num1 < num2  max = {num2} ");
}
else
{
    Console.WriteLine($"num1 == num2  max = {num1} ");
}


// Задача 11 
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456-> 46
// 782-> 72
// 918-> 98 

int numRand = new Random().Next(100, 1000);
System.Console.WriteLine(numRand);

int num_1 = num / 100;
int num_3 = num % 10;
int result = num_1*10 + num_3;

System.Console.WriteLine(result);

/*Задача 12
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно */

System.Console.WriteLine("enter first number: ");
int num_one = int.Parse(Console.ReadLine());
System.Console.WriteLine("enter second number: ");
int num_two = int.Parse(Console.ReadLine());
int diff = num_one % num_two;
if (diff == 0) 
{ 
    System.Console.WriteLine("Кратно");
}
else 
{
    System.Console.WriteLine($"не кратно, остаток {diff}");
 }

/* Задача 14
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
/*Задача 16
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет */

System.Console.WriteLine("enter first number: ");
int numOne = int.Parse(Console.ReadLine());
System.Console.WriteLine("enter second number: ");
int numTwo = int.Parse(Console.ReadLine());

if (numOne == Math.Pow(numTwo, 2) || numTwo == Math.Pow(numOne, 2)) 
{
    System.Console.WriteLine("да");
 }
else 
{
    System.Console.WriteLine("нет");
 }