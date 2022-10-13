/*Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/ 


Console.WriteLine("A(x1;y1;z1),B(x2,y2;z2)");
Console.Write("input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("AB lenght is: " + Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2- y1)+(z2-z1)*(z2-z1)), 2));



// Math.Round(),2));  используется для округления 
//Math.Sqrt это квадратный корень