/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/



int[] array = new int[8];

fillArray(array, 100, 999);
PrintArray(array);
EvenNumbers(array);

void EvenNumbers(int[] array)
{
    int count = 0;   //счетчик

    // сделаем перебор массива 

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine("количество чётных чисел в массиве: " + count);
}

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