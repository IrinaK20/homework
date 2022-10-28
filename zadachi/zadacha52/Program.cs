/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Random random = new Random();
int rows = random.Next(2, 6);
int columns = random.Next(3, 8);

int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SummArray(array);
void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


void SummArray(int[,] array)
{
    for (int j = 0; j < columns; j++)
    {
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        Console.Write(sum / rows + "\t");
    }
    Console.WriteLine();
}
