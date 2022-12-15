// HOMEWORK 5.2


Console.Clear();
Console.Write("Введите значение K1: ");
double K1 = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите значение B1: ");
double B1 = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите значение K2: ");
double K2 = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите значение B2: ");
double B2 = Convert.ToDouble (Console.ReadLine());

double x = (B2 - B1) / (K1 - K2);
double y = K1 * x + B1;

Console.WriteLine ($"({string.Join("; ", x, y )})");