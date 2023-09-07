//int num = new Random().Next(10, 100);
//Console.WriteLine(num);
//int num2 = num / 10;
//int num1 = num % 10;
//if (num1 > num2)
//{
//    Console.Write("макс число ");
//    Console.WriteLine(num1);
//}
//else
//{
//    Console.Write("Макс число ");
//    Console.WriteLine(num2);
//}

using System;
using static System.Console;

Clear();
int number = new Random().Next(10, 100);
int a1 = number / 10;
int a2 = number % 10;

if (a1 > a2)
{
    WriteLine($"{number}->{a1}");
}
else
{
    WriteLine($"{number}->{a2}"); 
}