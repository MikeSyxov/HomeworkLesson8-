// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

//     M = 1; N = 5 -> "2, 4"
//     M = 4; N = 8 -> "4, 6, 8"

static int ReadInt(string message)
{
    System.Console.Write($"{message} -> ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }

    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int m = ReadInt("Введите натуральное число M: ");
int n = ReadInt("Введите натуральное число N: ");

if (m > n)
{
    System.Console.WriteLine("Введите числа реверсивно, число М должно быть меньше числа N, либо N больше числа M.");
    return;
}

static void PrintNaturalNums(int n, int m)
{
    if (m > n) return;

    PrintNaturalNums(n - 1, m);
    if (n % 2 == 0)
        System.Console.Write($"{n}, "); //вверх
}
PrintNaturalNums(n, m);