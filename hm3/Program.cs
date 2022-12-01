// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int m = Prompt("Введите M: ");
int n = Prompt("Введите N: ");
Console.WriteLine($"M={m}, N={n}");


int Recursion(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Recursion(m - 1, 1);
    } 
    else
    {
        return Recursion(m - 1, Recursion(m, n - 1));
    }
}
int nums = Recursion(m, n);
System.Console.WriteLine($"A({m},{n}) = {nums}");