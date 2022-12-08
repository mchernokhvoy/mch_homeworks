// HOMEWORK 4.3

Console.Clear();
Console.Write("Введите числа: ");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
int n4 = int.Parse(Console.ReadLine());
int n5 = int.Parse(Console.ReadLine());
int n6 = int.Parse(Console.ReadLine());
int n7 = int.Parse(Console.ReadLine());
int n8 = int.Parse(Console.ReadLine());
int[] array = { n1, n2, n3, n4, n5, n6, n7, n8 };
Console.WriteLine($"[{string.Join(", ", array)}]");