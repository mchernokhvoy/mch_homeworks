// HOMEWORK 9.2


int akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (n > 0 && m == 0)
        return akkerman(n - 1, 1);
    else if (n > 0 && m > 0)
        return akkerman(n - 1, akkerman(n, m - 1));
    return akkerman(n, m);
}

Console.Clear();
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
while (n < 0 || m < 0)
{
    Console.Write("Вы ввели отрицательное число!\n");
    Console.Write("Введите число n: ");
    n = int.Parse(Console.ReadLine());
    Console.Write("Введите число m: ");
    m = int.Parse(Console.ReadLine());
}
Console.Write(akkerman(n, m));