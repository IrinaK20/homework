/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/


Console.WriteLine("Введите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = FillMatrix(m, n);
int[,] secondMatrix = FillMatrix(m, n);

Console.WriteLine($"Первая матрица ");
PrintMatrix(firstMatrix);
Console.WriteLine($"Вторая матрица ");
PrintMatrix(secondMatrix);

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] multiMatrix = multiMatrix = new int[m, n];
for (int i = 0; i < multiMatrix.GetLength(0); i++)
{
    for (int j = 0; j < multiMatrix.GetLength(1); j++)
    {
        multiMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
    };
}
Console.WriteLine($"Произведение первой и второй матрицы ");
PrintMatrix(multiMatrix);





