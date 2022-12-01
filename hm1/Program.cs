// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int m = Prompt("Введите M: ");
int n = Prompt("Введите N: ");
Console.WriteLine($"M = {m}, N = {n}");


string FindNumbers(int m, int n)
{
    if (m <= n)
    {
        if (m % 2 == 0)
        {
            System.Console.Write($"{m} ");
        }
        return FindNumbers(m + 1, n);
    }
    else return String.Empty;
}

System.Console.WriteLine(FindNumbers(m, n));