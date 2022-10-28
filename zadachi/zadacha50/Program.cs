/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого элемента в массиве нет*/

Random random = new Random();
int rows = random.Next(2, 6);
int columns = random.Next(3, 8);

int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);

Console.WriteLine("Введите номер строки искомого элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца искомого элемента: ");
int column = Convert.ToInt32(Console.ReadLine());

if (row >= 1 && row <= rows && column >= 1 && column <= columns)
{
    Console.WriteLine($"искомый элемент [{row}, {column}]={array[row - 1, column - 1]}");    // это как видит пользователь
}
else
{
    Console.WriteLine("искомый элемент не найден");
}


void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 11);
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