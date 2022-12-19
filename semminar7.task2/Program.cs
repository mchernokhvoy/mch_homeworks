// HOMEWORK 7.2

Console.Clear();
Console.Write("Введите позицию элемента в массиве: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int[,] matrix = new int[6, 6];
InputMatrix(matrix);

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
    if (x >= 0 && y >= 0 &&  x < matrix.GetLength(0) && y < matrix.GetLength(1))
    {
        Console.Write($"Заданный элемент массива = {matrix[x, y]} ");
    }
    else
    {
        Console.Write("Заданый элемент находится вне пределов массива");
    }
}
Console.WriteLine();
ReleaseMatrix(matrix);