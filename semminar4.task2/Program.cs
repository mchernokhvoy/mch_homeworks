// HOMEWORK 4.2

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int result = 0;
while (n / 10 >= 1)
{
    result = result + (n % 10);
    n = n / 10;
}
if (n / 10 >= 0)
    result = result + n;
Console.Write(result);