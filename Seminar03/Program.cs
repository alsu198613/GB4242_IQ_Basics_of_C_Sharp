/* Задача №17.Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
 */

Console.WriteLine("Enter number X:");
int numX = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number Y:");
int numY = int.Parse(Console.ReadLine());

if (numX > 0 && numY > 0)
{
    Console.WriteLine("Quarter I");
}
else if (numX < 0 && numY > 0)
{
    Console.WriteLine("Quarter II");
}
else if (numX < 0 && numY < 0)
{
    Console.WriteLine("Quarter III");
}
else if (numX > 0 && numY < 0)
{
    Console.WriteLine("Quarter VI");
}

// Задача 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).

Console.WriteLine("Enter number of quarter:");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("x > 0, y > 0");
}
else if (num == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
else if (num == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
else if (num == 4)
{
    Console.WriteLine("x > 0, y < 0");
}
else
{
    Console.WriteLine("Wrong quarter");
}

//2 вариант
Console.WriteLine("Enter number of quarter");
int numQ = int.Parse(Console.ReadLine());

switch (numQ)
{
    case 1: Console.WriteLine("X>0, Y>0"); break;
    case 2: Console.WriteLine("X<0, Y>0"); break;
    case 3: Console.WriteLine("X<0, Y<0"); break;
    case 4: Console.WriteLine("X>0, Y<0"); break;
    default: Console.WriteLine("Wrong quarter num"); break;

}

/* Задача
На вход будет подаваться число(сумма вклада).При значении меньше 100, будет начислено 5 %, 
если значение находится в диапазоне от ста до двухсот — 7 %, если больше — 10 %.Отработав, 
программа должна вывести общую сумму с начисленными процентами. Для решения этой задачи воспользуемся выражением 
Convert.ToDouble(Console.ReadLine()), которое нам пригодится для получения вводимого с клавиатуры числа.
Пусть банк регулярно начисляет по всем вкладам не только положенные по договору проценты, но еще и бонусы. И пусть, к примеру, 
 банк решит выполнить доначисление по всем клиентским вкладам в размере 15 единиц без учета суммы. Поменяем программу, 
 отображенную выше, чтобы к итоговой сумме были добавлены еще и бонусы.
*/
Console.WriteLine("Enter amount:");
double amount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите бонус: ");
double bonus = Convert.ToDouble(Console.ReadLine());
if (amount < 100)
{
    amount *= 1.05;
}
else if (amount < 200)
{
    amount *= 1.07;
}
else if (amount > 200)
{
    amount *= 1.1;
}

Console.WriteLine($"Total amount = {amount}");
Console.WriteLine($"Total amount + bonus = {amount + bonus}");

/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Enter X1:");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y1:");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter X2:");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y2:");
int y2 = int.Parse(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
string result2 = string.Format("{0:N2}", result);

Console.WriteLine(result2);

/* Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
Console.WriteLine("Enter N:");
int numberN = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberN; i++)
{
    Console.Write($"{Math.Pow(i, 2)}, ");
}