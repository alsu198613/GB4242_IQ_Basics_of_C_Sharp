/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
 */

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
int first_digit = num / 10000 % 10;
int second_digit = num / 1000 % 10;
int fourth_digit = num / 10 % 10;
int fifth_digit = num % 10;

if (first_digit == fifth_digit && second_digit == fourth_digit)
{
    Console.WriteLine("да");
} else 
{
    Console.WriteLine("нет");
} 

/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B(2, 1, -7), -> 15.84
A(7, -5, 0); B(1, -1, 9)-> 11.53 */

Console.WriteLine("Enter X1:");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y1:");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Z1:");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter X2:");
int X2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y2:");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Z2:");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(X2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
string result2 = string.Format("{0:N2}", result);

Console.WriteLine(result2);


/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Enter N:");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
}