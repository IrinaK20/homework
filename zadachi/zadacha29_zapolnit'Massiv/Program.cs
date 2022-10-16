/*Напишите программу, которая задаёт массив произвольной длины, заполняет произвольными элементами
 и выводит их на экран. Длину массива и элементы массива можно задать рандомно или 
 попросить пользователя ввести в консоли.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/ 


void newArray(int[] array)
{
     int length = array.Length;
     int index = 0;
    while (index < length)
     {
         Console.WriteLine($"Введите элемент массива [{index}]:");
         int N = Convert.ToInt32(Console.ReadLine());
         array[index] = N;
         index++;
     }
 }
 void PrintArray(int[] arr)
 {
     int count = arr.Length;
     int index = 0;
     while (index < count)
     {
        Console.Write(arr[index] + " ");
         index++;
     }
}
 int[] array = new int[8];
 int count = array.Length;

 newArray(array);
 PrintArray(array);
