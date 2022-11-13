/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

Random random = new Random();
int rows = 3;
int columns = 4;

int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
Console.WriteLine();


void FillArray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

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
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        for (int k = 0; k < columns - j - 1; k++)
        {
            if (array[i, k] < array[i, k + 1])
            {
                int t = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = t;
            }
        }
    }
}
PrintArray(array);




