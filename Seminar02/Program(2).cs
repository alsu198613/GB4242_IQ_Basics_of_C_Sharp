// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random().Next(10, 100);

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


//GB HW
//10. Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
Console.Clear();

num = new Random().Next(100, 1000);
int secondNumber = num / 10 % 10;
Console.WriteLine($"Вторая цифра в числе {num} -> {secondNumber}");

//13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

Console.Clear();
Console.Write("Введите число: ");
num = int.Parse(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine($"Третьей цифры нет");
    return;
}
int thirdNumber = (num / 100) % 10;
Console.WriteLine($"Третья цифра числа {num} -> {thirdNumber}");

//15. Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите число: ");
num = int.Parse(Console.ReadLine());
if ((num > 7) || (num < 1))
{
    Console.WriteLine("Неверный день недели");
    return;
}
if ((num > 5))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
//end

//My HW
int SetNumber(string text = "")
{
    Console.Write($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//То что дала GeekBrains
//645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6



// Console.WriteLine("Enter index : ");
// int index = Convert.ToInt32(Console.ReadLine());

//double pow = Math.Pow(10, index);

num = SetNumber();
Console.Clear();

if (num < 100)
{
    Console.WriteLine($"Цифра меньше индекса 3");

}
else
{

    int tmp = num;

    while (tmp >= 1000)
    {
        tmp /= 10;
    }

    int result = tmp % 10;

    Console.WriteLine($"Цифра под индексом 3 числа {num} -> {result}");
}


//15. Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

//1
Console.WriteLine("Enter dayWeek : ");
string strDayWeek = Console.ReadLine();

PrintIsWeekend(strDayWeek);

void PrintIsWeekend(string dayWeek)
{

    switch (dayWeek)
    {
        case "1":
            Console.WriteLine("Понедельник- НЕТ");
            break;
        case "2":
            Console.WriteLine("Вторник- НЕТ");
            break;
        case "3":
            Console.WriteLine("Среда- НЕТ");
            break;
        case "4":
            Console.WriteLine("Четверг- НЕТ");
            break;
        case "5":
            Console.WriteLine("Пятница- Да");
            break;
        case "6":
            Console.WriteLine("Суббота- Нет");
            break;
        case "7":
            Console.WriteLine("Воскресенье- Нет");
            break;

    }

}

//2 

bool ValidateWeekday(int dayWeek)
{
    return dayWeek >= 1 && dayWeek <= 7 ? true : false;
}

string PrintWeekendDay(int dayWeek)
{
    return dayWeek > 5 && dayWeek <= 7 ? "Weekend)))" : "Work day(((";
}

int weekDay = SetNumber("week day");

if (ValidateWeekday(dayWeek))
{
    System.Console.WriteLine(PrintWeekendDay(weekDay));
}
else
{
    System.Console.WriteLine("Week day not valid()");
}

//end





