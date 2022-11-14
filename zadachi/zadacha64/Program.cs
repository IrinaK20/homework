/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/ 

Console.WriteLine("введите число");

int b = Convert.ToInt32(Console.ReadLine());
int a = 1;
string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b)+ $"{a} ";
    else return String.Empty;
}

Console.WriteLine(NumbersRec(a,b)); 
