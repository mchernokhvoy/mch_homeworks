﻿// HOMEWORK 3.2

Console.Clear();
Console.Write("Введите координату точки А: ");
double xa = Convert.ToDouble (Console.ReadLine ());
double ya = Convert.ToDouble (Console.ReadLine ());
double za = Convert.ToDouble (Console.ReadLine ());

Console.Write("Введите координату точки В: ");
double xb = Convert.ToDouble (Console.ReadLine ());
double yb = Convert.ToDouble (Console.ReadLine ());
double zb = Convert.ToDouble (Console.ReadLine ());

double result = Math.Sqrt (Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));

Console.WriteLine($"Расстояние между точками: {result}");