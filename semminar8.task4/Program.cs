// HOMEWORK 8.4

void InputMatrix(int[,,] matrix)
{
    int num = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                matrix[i, j, k] = num++;
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.WriteLine($"{matrix[i, j, k]} ({i}, {j}, {k})");
        }
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0] * size[1] * size[2] > 90 || size[0] * size[1] * size[2] == 0)
{
    Console.Write("Размер задан некорректно.\nВведите размер матрицы: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,,] matrix = new int[size[0], size[1], size[2]];
InputMatrix(matrix);
PrintMatrix(matrix);