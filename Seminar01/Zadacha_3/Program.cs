// Задача №3.Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Enter nummber of the day of the week");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота"); break;
    case 7: Console.WriteLine("Воскресенье"); break;
    default: Console.WriteLine("Такого нет"); break;
}

//вариант с if-else
Console.Clear();

Console.Write("Введите номер дня недели: ");
int numberDayOfWeek = Convert.ToInt32(Console.ReadLine());

if (numberDayOfWeek == 1)
{
    Console.WriteLine("Понедельник");
}
else if (numberDayOfWeek == 2)
{
    Console.WriteLine("Вторник");
}
else if (numberDayOfWeek == 4)
{
    Console.WriteLine("Среда");
}
else if (numberDayOfWeek == 4)
{
    Console.WriteLine("Четверг");
}
else if (numberDayOfWeek == 5)
{
    Console.WriteLine("Пятница");
}
else if (numberDayOfWeek == 6)
{
    Console.WriteLine("Суббота");
}
else if (numberDayOfWeek == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Введен неправильный номер");
}


//Задача с двумя друзьями и собакой 

int count = 0;
int distance = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;



while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (FirstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (SecondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
    count++;
}

Console.WriteLine($"Количество раз, за которое собака пробежит, равно - {count}");
