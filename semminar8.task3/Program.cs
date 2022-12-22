// HOMEWORK 8.3

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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

int[,] ReleaseMatrix(int[,] FirstMatrix, int[,] SecondMatrix)
{
    int[,] ResultMatrix = new int[FirstMatrix.GetLength(0), FirstMatrix.GetLength(1)];
    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
            ResultMatrix[i, j] = FirstMatrix[i, j] * SecondMatrix[i, j];
    }
    return ResultMatrix;
}

Console.Clear();
Console.Write("Введите размер матриц: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] FirstMatrix = new int[size[0], size[1]];
int[,] SecondMatrix = new int[size[0], size[1]];
Console.WriteLine("Матрица 1: ");
InputMatrix(FirstMatrix);
Console.WriteLine("Матрица 2: ");
InputMatrix(SecondMatrix);
Console.WriteLine("Результат произведения:");
PrintMatrix(ReleaseMatrix(FirstMatrix, SecondMatrix));