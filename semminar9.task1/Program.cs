// HOMEWORK 9.1

int sum (int n, int m)
{
    if (n == m)
        return m;
    return sum (n + 1, m) + n;
}

Console.Clear();
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Сумма = ");
Console.WriteLine(sum(n, m));