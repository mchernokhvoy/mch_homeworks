// HOMEWORK 6.extra

Console.Clear();
Console.Write("Введите координату высоты A: ");
double x1 = Convert.ToDouble (Console.ReadLine ());
double y1 = Convert.ToDouble (Console.ReadLine ());

Console.Write("Введите координату высоты B: ");
double x2 = Convert.ToDouble (Console.ReadLine ());
double y2 = Convert.ToDouble (Console.ReadLine ());

Console.Write("Введите координату высоты C: ");
double x3 = Convert.ToDouble (Console.ReadLine ());
double y3 = Convert.ToDouble (Console.ReadLine ());


double AB = Math.Sqrt (Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
double BC = Math.Sqrt (Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
double CA = Math.Sqrt (Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

double p = (AB + BC + CA) / 2;
double result = Math.Round (Math.Sqrt (p * (p - AB) * (p - BC) * (p - CA)), 2);

Console.WriteLine($"Площадь треугольника равна: {result}");