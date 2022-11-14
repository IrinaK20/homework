/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


/*Console.WriteLine("введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число N");
int N = Convert.ToInt32(Console.ReadLine());
string NumbersRec(int N, int M);*/


int M = InputNumber("введите число M: ");
int N = InputNumber("введите число N: ");
int temp = M;

if (M > N)
{
    M = N;
    N = temp;
}
Console.Write("сумма:");
PrintSum(M, N, temp = 0);

int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintSum(int M, int N, int sum)
{
    sum = sum + N;
    if (N <= M)
    {
        Console.Write($" {sum} ");
        return;
    }
    PrintSum(M, N - 1, sum);

}

