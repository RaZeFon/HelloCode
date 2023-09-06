using System;

//первая задача
Console.Clear();
Console.Write("Введите первое число ");
int num_1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int num_2 = int.Parse(Console.ReadLine());
if (num_1 > num_2)
{
    Console.Write("max = ");
    Console.WriteLine(num_1);
    Console.Write("min = ");
    Console.WriteLine(num_2);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(num_2);
    Console.Write("min = ");
    Console.WriteLine(num_1);
}