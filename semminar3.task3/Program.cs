// HOMEWORK 3.3


Console.Clear();
Console.Write("Введите пятизначное число N: ");
int N = int.Parse (Console.ReadLine());

if ( N / 10000 >=1 && N / 10000 < 10)
    if ( N / 10000 == N %10 && (N / 1000) %10  == (N % 100) / 10)
    Console.Write("Полиндром");
    else 
     Console.Write("Не полиндром");

else
    Console.Write("Вы ввели не пятизначное число, повторите попытку");