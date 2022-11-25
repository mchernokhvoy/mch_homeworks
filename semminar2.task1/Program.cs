// HOMEWORK 2.1

Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
if (a >= 100 && a < 1000)
    Console.Write(a = (a - ((a / 100) * 100) - (a % 10)) / 10);
else
    Console.Write("Вы ввели не трёхзначное число, повторите попытку");