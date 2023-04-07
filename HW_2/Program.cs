/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
if (num < 100 || num > 1000)
{
    Console.WriteLine("You entered wrong number");
}
else
{
    Console.WriteLine(num);
}

int result = num / 10 % 10;
Console.WriteLine(result);

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(num);
    while (num > 999)
    {
        num /= 10;

    }
    third_num = num % 10;
}

Console.WriteLine(third_num);


/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());

if (number < 0 && number > 7)
{
    Console.WriteLine("Такого дня нет");
}
else if (number > 0 && number < 6)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}



