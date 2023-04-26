// Задача 64: Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от M до N.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int M = SetNumber();
Console.WriteLine(M);
int N = SetNumber();
Console.WriteLine(N);

int[] array = GetNumFromInterval(M, N);
Console.WriteLine($"Все натуральные числа в промежутке от {M} до {N}: [{String.Join(", ", array)}]");



int SetNumber(string text = "")
{
    Console.WriteLine($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] GetNumFromInterval(int startValue, int endValue)
{
    int size = M - N + 1;
    int[] result = new int[size];
    for (int i = M; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}