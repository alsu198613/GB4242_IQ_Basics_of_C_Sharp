/*
// Массив вопросов и ответов на них
string[,] questions = { {"Сколько будет 2+2?", "4"},
{"Как называется самый большой океан?", "Тихий"},
{"Кто расколол орех Петру Первому во сне?", "Лиза"},
{"Сколько часов в сутках?", "24"} };

string[,] answers = { {"2", "4","5","8"},
{"атлантический", "тихий","индийский","северный"},
{"коля", "оля", "лиза", "дима"},
{"12", "15", "18","24"} };

// счётчики ответов
int true_answer = 0;
int false_answer = 0;
// перебираем все вопросы в массиве
for (int i = 0; i < questions.GetLength(0); i++)
{
    // выводим очередной вопрос
    Console.WriteLine($"{i + 1}. {questions[i, 0]}");
    Console.WriteLine("Варианты ответа: ");
    for (int j = 0; j < answers.GetLength(0); j++)
    {
        Console.WriteLine($"{j + 1}. {answers[i, j]}");
    }
    // получаем ответ от пользователя
    Console.Write("Ответ: ");
    string answer = Console.ReadLine();
    // проверяем правильность ответа переводим в нижний регистр избежав регистровых ошибок
    if (answer.ToLower() == questions[i, 1].ToLower())
    {
        Console.WriteLine("Правильно!");
        true_answer++;
    }
    else
    {
        Console.WriteLine($"Не правильно. Правильный ответ: {questions[i, 1]}");
        false_answer++;
    }   
}

Console.WriteLine("Викторина завершена.");
Console.WriteLine($"Правильных ответов: {true_answer}");
Console.WriteLine($"Неправильных ответов: {false_answer}");
*/

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int SumNumbers(int number)
{
    if (number == 0) return 0;

    return (number % 10 + SumNumbers(number / 10));
    //return number == 0 ? 0 : (number % 10 + SumNumbers(number / 10));
}

Console.WriteLine($"Сумма цифр числа {num} равна {SumNumbers(num)}");