using System;

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int ost = num % 10;
Console.WriteLine(ost);