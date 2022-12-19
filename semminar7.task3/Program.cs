// HOMEWORK 7.3


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
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        string average = string.Empty;
        double result = 0;
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        result = Math.Round(sum / matrix.GetLength(0), 2);
        average = Convert.ToString(result); 
        Console.Write($"{average + "; "}");
    }
}

Console.Clear();
int[,] matrix = new int[4, 6];
InputMatrix(matrix);
Console.WriteLine();
Console.Write("AVERAGE: ");
ReleaseMatrix(matrix);