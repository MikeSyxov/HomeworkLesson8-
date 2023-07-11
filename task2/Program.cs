// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//     M = 1; N = 15 -> 120
//     M = 4; N = 8 -> 30

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

int M = ReadInt("Введите натуральное число M: ");
int N = ReadInt("Введите натуральное число N: ");

int temp = M;

if (M > N)
{
  M = N;
  N = temp;
}

PrintSumNaturalNums(M, N, temp = 0);

void PrintSumNaturalNums(int M, int N, int summ)
{
  summ = summ + N;
  if (N <= M)
  {
    Console.Write($"сумма натуральных элементов в промежутке от M до N -> {summ} ");
    return;
  }
  PrintSumNaturalNums(M, N - 1, summ);
}
