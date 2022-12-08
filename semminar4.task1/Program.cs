// HOMEWORK 4.1


Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
int i = 1;
int result = 1;
while (i <= b)
{
    result = result * a;
    i = i + 1;
}
Console.Write(result);