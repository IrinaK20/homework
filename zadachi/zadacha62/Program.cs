/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

/*
int rows = 4;
int columns = 4;

int[,] array = new int[rows, columns];

int steps = columns;

int indI = 0;
int indJ = 0;

int changesI = 0;
int changesJ = 1;
int turn=0;

for (int i = 1; i <= array.Length; i++)
{
    array[indI, indJ] = i;
    Console.Write(array[indI, indJ] + "\t");
    steps--;
    if (steps == 0)   // заполнили строку и нужен поворот 
    {
        steps = rows - 1-turn/2; //-1 т.к кол-во элементов которые мы должны запонить уменьшается и вычитаем кол-во поворотов

        int temp = changesI;
        changesI = changesJ;
        changesJ = -temp;
        turn++;
    }

    indI = indI + changesI;
    indJ = indJ + changesJ;
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
Console.WriteLine();
PrintArray(array);*/

int n = 4;
int[,] spiral = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiral.GetLength(0) * spiral.GetLength(1))
{
  spiral[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiral.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiral.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiral.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(spiral);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}