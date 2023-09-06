using System;

//первая задача
Console.Clear();
Console.WriteLine("Задача 1");
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

//вторая задача 
Console.WriteLine(" ");
Console.WriteLine("Задача 2");
Console.Write("Введите первое число ");
int num_a1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int num_a2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число ");
int num_a3 = int.Parse(Console.ReadLine());
int max1 = num_a1;
if(num_a1 > max1) max1 = num_a1;
if(num_a2 > max1) max1 = num_a2;
if(num_a3 > max1) max1 = num_a3;
Console.Write("max = ");
Console.WriteLine(max1);

//третья задача
Console.WriteLine(" ");
Console.WriteLine("Задача 3");
Console.Write("(Проверка на четность) Введите число ");
int num_b1 = int.Parse(Console.ReadLine());
if (num_b1 % 2 == 0)
{
    Console.Write("Число ");
    Console.Write(num_b1);
    Console.WriteLine(" четное");
}
else
{
    Console.Write("Число ");
    Console.Write(num_b1);
    Console.WriteLine(" нечетное");
}

//четвертая задача
Console.WriteLine(" ");
Console.WriteLine("Задача 4");
Console.Write("Введите число N ");
int num_c1 = int.Parse(Console.ReadLine());
int count = 1;
while (count <= num_c1)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
    count++;
}  