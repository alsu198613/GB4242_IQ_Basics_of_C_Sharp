﻿/*Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
на само себя).

Например:
4 -> 16 
-3 -> 9 
-7 -> 49
*/

Console.WriteLine("Enter number");
string strNum = Console.ReadLine();
int num = Convert.ToInt32(strNum);

int sqr = num * num;
Console.WriteLine($"sqr = {sqr}");

