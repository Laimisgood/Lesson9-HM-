// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int m = Prompt("Введите M: ");
int n = Prompt("Введите N: ");
Console.WriteLine($"M={m}, N={n}");

string FindNumbers(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        return $"{sum}";
    }
    else return FindNumbers(m, n-1, sum);
}
int sum = 0;
System.Console.WriteLine(FindNumbers(m, n, sum));