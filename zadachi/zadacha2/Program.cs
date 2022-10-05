//программа, которая на вход приимает 2 числа и вдает, max  

/*
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

*/


Console.Write("введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.Write("введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine()); 
int max=a|b;
if (a > b)
{
Console.WriteLine("Число "+a+" большее, а число "+b+" меньшее");
}
else if (b > a)
{
Console.WriteLine("Число "+b+" большее, а число "+a+" меньшее");
}
else
{
Console.WriteLine("Числа равны");
}
