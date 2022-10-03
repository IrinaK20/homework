//принимает 3 числа и выдает max из этих чисел

Console.Write("введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max=a;

if(a>max) max=a;
if(b>max) max=b;
if(c>max) max=c;

Console.Write("max= ");
Console.WriteLine(max);



