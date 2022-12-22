// HOMEWORK 8.2


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
    int minRow = 0;
    // int minSumString = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
        minRow += matrix[0, j];
        // minSumString = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sumRowElements = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRowElements = sumRowElements + matrix[i, j];
        }
            if (sumRowElements < minRow)
                minRow = sumRowElements;
                // minSumString = i; 
    }
    // Console.Write($"Строка с минимальной суммой элементов: {i}\nСумма элементов строки = {minRow}");
    Console.Write($"Минимальная сумма элементов строки = {minRow}");
}

Console.Clear();
Console.Write("Введите размер прямоугольной матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0] == size[1] || size[0] == 0|| size[1] == 0)
{
    Console.Write("Вы ввели размер некорректный размер\nВведите размер прямоугольной матрицы: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);