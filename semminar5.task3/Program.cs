// HOMEWORK 5.3


void InputArray(double[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = Math.Round(new Random().NextDouble() * (2 - (-2)) + (-2), 2); 
}

void ReleaseArray(double[] array)
{
double min = 0, max = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] > max)
max = array[i];
if (array[i] < min)
min = array[i];
}
Console.WriteLine($"Разница между максимальным и минимальным значениями массива: {max - min}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);