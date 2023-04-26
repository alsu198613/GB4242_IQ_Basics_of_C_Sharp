// Задача 64: Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от M до N.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int M = SetNumber();
int N = SetNumber();

int[] array = GetNumFromInterval(M, N);
Console.WriteLine($"Все натуральные числа в промежутке от {M} до {N}: {String.Join(", ", array)}");


int SetNumber(string text = "")
{
    Console.WriteLine($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] GetNumFromInterval(int startValue, int endValue)
{
    int size = Math.Abs(endValue - startValue) + 1;

    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = startValue;
        if (startValue <= endValue)
        {
            startValue++;
        }
        else
        {
            startValue--;
        }
    }

    return result;
}


//Рекурсия
int numberM = SetNumber();
int numberN = SetNumber();
NaturalToLow(numberM, numberN);

void NaturalToLow(int m, int n)
{
    if (m < n)
    {
        return;
    }
    else
    {
        NaturalToLow(m, n + 1);
        Console.Write(n + " ");
    }
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

int numM = SetNumber("M");
int numN = SetNumber("N");

SumNumbers(numM, numN);

// вызов функции "сумма чисел от M до N"
void SumNumbers(int m, int n)
{
    Console.Write($"сумма натуральных элементов в промежутке от {m} до {n}: {SumMN(m - 1, n)}");
}

// функция сумма чисел от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}
Console.WriteLine();
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29

int m = SetNumber("m");
int n = SetNumber("n");

// вызов функции Аккермана
AkkermanFunction(m, n);

void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n));
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}