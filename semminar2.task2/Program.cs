// HOMEWORK 2.2


Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
while (a / 100 >=10 || a / 100 <=-10)
{
    a = a / 10;
}
if (a >= 100 && a < 1000)
    Console.Write(a = (a - (a / 10) * 10));
else if (a <= -100 && a > -1000)
    Console.Write(a = -(a - (a / 10) * 10));
else 
    Console.Write("Вы ввели не трёхзначное число, повторите попытку");