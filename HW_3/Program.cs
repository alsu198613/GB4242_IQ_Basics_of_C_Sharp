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

// 2 вариант
int numPalindrome = SetNumber("Palindrome");

bool isPalindrome = IsPalindromeInt(numPalindrome);

isPalindrome = IsPalindromeString(numPalindrome.ToString());

string str = isPalindrome ? "является палиндромом" : "не является палиндромом";

System.Console.WriteLine($"число {numPalindrome} {str}");

static bool IsPalindromeInt(int num)
{
    // num = 456654
    int temp = num;
    // temp = 456654
    int revert = 0;

    while (temp > 0)
    {
        //revert= 0*10=0 + 4=4
        //revert= 4*10=40 + 5=45
        //revert= 45*10=450 + 6=456
        //revert= 456*10=4560 + 6=4566
        //revert= 4566*10=45660 +5=45665
        //revert= 45665*10=456650 + 6=456654
        revert = (revert * 10) + (temp % 10);
        //temp = 45665
        //temp = 456
        //temp = 45
        //temp = 4
        temp /= 10;
    }

    return revert == num;
}

static bool IsPalindromeString(string str)
{

    int size = str.Length;
    for (int i = 0; i <= size / 2; ++i)
    {
        if (str[i] != str[size - 1 - i])
        {
            return false;
        }
    }
    return true;
}

int SetNumber(string numberName = "")
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
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
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y2:");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Z2:");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
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

//2 вариант
static int[] CubeTable(int n)
{
    int[] arr = new int[n];

    for (int i = 1; i <= n; i++)
    {
        arr[i - 1] = i * i * i;
    }

    return arr;
}

int numb = SetNumber("N");
int[] array = CubeTable(numb);

Console.WriteLine(String.Join(", ", array));