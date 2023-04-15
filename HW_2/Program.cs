/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

//метод ввода числа через консоль
int numb = SetNumber();

int SetNumber (string text = "")
{
    Console.WriteLine($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
if (num < 100 || num > 999)
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
int numb = int.Parse(Console.ReadLine());

if (numb < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int tmp = numb;
    while (tmp >= 1000)
    {
        tmp /= 10;

    }
    int third_num = tmp % 10;
    Console.WriteLine($"3 цифра числа {num} -> {third_num}");   
}


/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());

if (number < 1 || number > 7)
{
    Console.WriteLine("Такого дня нет");
}
if (number > 0 && number < 6)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

// 2 вариант
Console.WriteLine("Enter dayWeek : ");
string strDayWeek = Console.ReadLine();

PrintIsWeekend(strDayWeek);

void PrintIsWeekend(string dayWeek)
{

    switch (dayWeek)
    {
        case "1": Console.WriteLine("Понедельник- НЕТ"); break;
        case "2": Console.WriteLine("Вторник- НЕТ"); break;
        case "3": Console.WriteLine("Среда- НЕТ"); break;
        case "4": Console.WriteLine("Четверг- НЕТ"); break;
        case "5": Console.WriteLine("Пятница- НЕТ"); break;
        case "6": Console.WriteLine("Суббота- ДА"); break;
        case "7": Console.WriteLine("Воскресенье- ДА"); break;

    }

}

//3 вариант

int SetNumber(string text = "")
{
    Console.Write($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


bool ValidateWeekday(int dayWeek)
{
    return dayWeek >= 1 && dayWeek <= 5 ? false : true;
}

string PrintWeekendDay(int dayWeek)
{
    return dayWeek > 5 && dayWeek <= 7 ? "Weekend)))" : "Work day(((";
}

int weekDay = SetNumber("week day");

if (ValidateWeekday(weekDay))
{
    System.Console.WriteLine(PrintWeekendDay(weekDay));
}
else
{
    System.Console.WriteLine("Week day not valid()");
}


