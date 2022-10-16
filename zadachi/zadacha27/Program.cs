/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12   */


Console.Write("введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int result = 0;

while (a > 10)
{
    int a1 = a % 10;
    sum = sum + a1;
    a = a / 10;
}
if (a<10)
{
    result = sum + a;
}

Console.WriteLine($"Сумма цифр во введенном числе равна {result}");