// HOMEWORK 2.3


Console.Clear();
Console.Write("Введите число a в диапозоне от 1 до 7, обозначающее день недели: ");
int a = int.Parse(Console.ReadLine());
if (a >= 1 && a <= 5)
    Console.Write("будний день");
if (a == 6 || a == 7)
    Console.Write("выходной день");
else
    Console.Write("вы ввели некорректное число, укажите число от 1 до 7");