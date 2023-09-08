//using System;
//using static System.Console;

//Clear();
//WriteLine("Введите координаты первой точки A: ");
//Write("x1 = ");
//int x1 = int.Parse(ReadLine());
//Write("y1 = ");
//int y1 = int.Parse(ReadLine());
//WriteLine("Введите координаты первой точки B: ");
//Write("x2 = ");
//int x2 = int.Parse(ReadLine());
//Write("y2 = ");
//int y2 = int.Parse(ReadLine());
//int rezX = (x1 - x2);
//int rezY = (y1 - y2);
//double rezX1 = Math.Pow(rezX, 2);
//double rezY1 = Math.Pow(rezY, 2);
//double rezXY = rezX1 + rezY1;
//double rez = Math.Sqrt(rezXY);
//WriteLine($"Растояние между ними: {rez}");


using System;
using static System.Console;

Clear();
Write("Введите x1: ");
int x1 = int.Parse(ReadLine());
Write("Введите y1: ");
int y1 = int.Parse(ReadLine());
Write("Введите x2: ");
int x2 = int.Parse(ReadLine());
Write("Введите y2: ");
int y2 = int.Parse(ReadLine());
double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
WriteLine($"Длина отрезка = {d:f4}");