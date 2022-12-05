// HOMEWORK 1.1


Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse (Console.ReadLine());

if (N > 0)
    for (int i = 1 ; i <=N ; i++)
    Console.Write ($"{i*i*i} ");

else if (N < 0)
    for (int i = -1 ; i >=N ; i--)
    Console.Write ($"{i*i*i} ");