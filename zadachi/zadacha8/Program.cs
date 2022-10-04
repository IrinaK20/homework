// принимает число N, а на выходе показывает все четные числа от 1 до N

Console.Write("введите число: ");
int N=Convert.ToInt32(Console.ReadLine());

for(int i=2;i<=N;i+=2)
{
    Console.WriteLine(i);
}


