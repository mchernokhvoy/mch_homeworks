// HOMEWORK 1.2

Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse (Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse (Console.ReadLine());
Console.Write("Введите число c: ");
int c = int.Parse (Console.ReadLine());
if (a > b && a > c)
    Console.Write(a);
if (b > a && b > c)
    Console.Write(b);
if (c > a && c > b)
     Console.Write(c);
     