//программа, которая на вход приимает 2 числа и вдает, max  


Console.Write("введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.Write("введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine()); 
int max=a|b;
if (a>b)
{
    Console.WriteLine(a=max);
}
else
{
    Console.WriteLine(b=max);
}

