/*выводит третью цифру числа или сообщает, что третьей цифры нет*/

Console.Write("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a >= 100)
{
    if (a > 999)
    {
        int i = 10;
        while (a/i>1000)
        {
            i=i*10;
        }
        Console.Write("третья цифра: " +(a/i)%10);
    }
    else
    {
       Console.Write("третья цифра: " + a%10);
    }

}
else
{
    Console.Write("третьей цифры нет");
}