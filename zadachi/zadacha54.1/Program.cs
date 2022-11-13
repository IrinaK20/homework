/*Задайте двумерный массив. Напишите программу, которая упорядочит элементы по убыванию (или возрастанию).*/

Random random = new Random();
int rows = 4;
int columns = 3;

int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
Console.WriteLine();
FinalArray(array);
PrintArray(array);


void FillArray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 21);
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

void FinalArray(int[,] array)
{
    int count =0;
    int [] array2 = new int [rows*columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array2[count]=array[i,j];
            count++;
        }
    }

    Array.Sort(array2);
    Array.Reverse(array2);
    count=0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j]=array2[count];
            count++;
        }
    } 
}




