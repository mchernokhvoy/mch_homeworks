// HOMEWORK 5.1

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
}

void ReleaseArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            result = result + 1;
    }
    Console.WriteLine($"Количество чётных элементов массива: {result}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);