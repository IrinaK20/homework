/*: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


int[] array = new int[8];

fillArray(array, 0, 10);
PrintArray(array);

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
    {
        sum += array[i];
    }
}
Console.WriteLine("сумма элементов, стоящих на нечётных позициях: " + sum);

// метод заполнения массива 
void fillArray(int[] array, int startNumber = 0, int finishNumber = 1)
{
    finishNumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
}

// метод печати массива
void PrintArray(int[] array)
{
    Console.WriteLine("вывод массива");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}
