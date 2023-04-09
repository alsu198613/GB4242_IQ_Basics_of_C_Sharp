/* Задача №17.Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
 */
/*
System.Console.WriteLine("Enter number of quarter:");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
    System.Console.WriteLine("x > 0, y > 0");
}
else if (num == 2)
{
    System.Console.WriteLine("x < 0, y > 0");
}
else if (num == 3)
{
    System.Console.WriteLine("x < 0, y < 0");
}
else if (num == 4)
{
    System.Console.WriteLine("x > 0, y < 0");
}
else
{
    System.Console.WriteLine("Wrong quarter");
}

/* Задача
На вход будет подаваться число(сумма вклада).При значении меньше 100, будет начислено 5 %, 
если значение находится в диапазоне от ста до двухсот — 7 %, если больше — 10 %.Отработав, 
программа должна вывести общую сумму с начисленными процентами. Для решения этой задачи воспользуемся выражением 
Convert.ToDouble(Console.ReadLine()), которое нам пригодится для получения вводимого с клавиатуры числа.
Пусть банк регулярно начисляет по всем вкладам не только положенные по договору проценты, но еще и бонусы. И пусть, к примеру, 
 банк решит выполнить доначисление по всем клиентским вкладам в размере 15 единиц без учета суммы. Поменяем программу, 
 отображенную выше, чтобы к итоговой сумме были добавлены еще и бонусы.

System.Console.WriteLine("Enter amount:");
    double amount = Convert.ToDouble(Console.ReadLine());

    if (amount < 100)
    {
        amount = amount + amount * 0.05;
    }
    else if (amount < 200)
    {
        amount = amount + amount * 0.07;
    }
    else
    {
        amount = amount + amount * 0.1;
    }
    System.Console.WriteLine($"Total amount = {amount}");

/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21


System.Console.WriteLine("Enter X1:");
int x1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter Y1:");
int y1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter X2:");
int X2 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter Y2:");
int y2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(X2 - x1, 2) + Math.Pow(y2 - y1, 2));
string result2 = string.Format("{0:N2}", result);

System.Console.WriteLine(result2);
*/
/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
System.Console.WriteLine("Enter N:");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    System.Console.Write($"{Math.Pow(i, 2)}, ");
}