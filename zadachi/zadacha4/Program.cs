//принимает 3 числа и выдает max из этих чисел

Console.Write("введите первое чисо: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе чисо: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье чисо: ");
int c = Convert.ToInt32(Console.ReadLine());

int max=a;

if(a>max) max=a;
if(b>max) max=b;
if(c>max) max=c;

Console.Write("max= ");
Console.WriteLine(max);



