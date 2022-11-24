// HOMEWORK 1.1

Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse (Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse (Console.ReadLine());
if (a < b)
Console.Write("min = a, max = b");
else
Console.Write("min = b, max = a");
