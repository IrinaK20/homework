// ввести трехзначное число и на выходе показать вторую цифру этого числа 

Console.Write("введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a >= 100 && a<=999)
{
    int first = a / 10;
    int second = first % 10;
    Console.Write("вторая цифра: " + second);
}
else
{
    Console.Write("ввели некорректное число: ");
}

