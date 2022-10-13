/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/


Console.WriteLine("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int index=0;
int stepen=3;

for (int i=1; i<=n; i++)
{
    index=Convert.ToInt32(Math.Pow((int) i,stepen));
    Console.Write(index + " ");
}
