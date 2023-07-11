// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//     m = 3, n = 2 -> A(m,n) = 29

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

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


if (m > 2 && n < 2)
{
    System.Console.WriteLine("Не вводите числа больше 4 иначе мировой пузырь лопнет");
    return;
}

static int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    return Ackermann(m - 1, Ackermann(m, n - 1));
    {
        Console.WriteLine($"Ackermann({0}, {1}) = {2}", n, m, Ackermann(n, m));
    }
}

void PrintFnAckermann(int m, int n)
{
    Console.Write(Ackermann(m, n));
}

PrintFnAckermann(m, n);