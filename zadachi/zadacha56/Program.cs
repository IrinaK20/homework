/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка*/

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


int MinSum = 0;
int LineMin = 0;

for (int j = 0; j < columns; j++)       // пройдем по первой строке и запишем результат в MinSum
{
    MinSum = MinSum + array[0, j];
}
Console.WriteLine($"сумма 1 строки равна: {MinSum}");

for (int i = 1; i < rows; i++)            // перебираем массив, начинаем с 1, т.к. первуюстроку уже посчитали 
{
    int sum = 0;
    for (int j = 0; j < columns; j++)
    {
        sum = sum + array[i, j];                    // ищем сумму каждой строки 
    }
    Console.WriteLine($"сумма {i + 1} строки равна: {sum}");

    if (sum < MinSum)
    {
        MinSum = sum;
        LineMin=i;
    }
}
Console.WriteLine();
Console.WriteLine($"минимальная сумма в строке: {LineMin+1}");  // +1 для удобства пользователя 