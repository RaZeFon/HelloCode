//using System;
<<<<<<< HEAD
//Console.Write("Введите чило A: ");
//int number_A = int.Parse(Console.ReadLine());
//int i = 0;
//int sum = 0;
//while(i <= number_A)
//{
//    sum = sum + i;
//    i++;
//}
//Console.WriteLine(sum);


//using System;
//using static System.Console;
//Write("Введите число N: ");
//int N = int.Parse(ReadLine());
//int summa = GetSumNumbers(N);
//WriteLine($"Сумма = {summa}");
//int GetSumNumbers(int number)
//{
//    int sum = 0;
//    for (int i = 1; i <= number; i++)
//    {
//        sum = sum + i;
//    }
//    return sum;
//}


//using System;
//using static System.Console;
//Write("Введите число: ");
//string number = ReadLine();
//int result = StrNum(number);
//WriteLine($"Колличество = {result}");

//int StrNum(string num)
//{
//    int count = 0;
//    for (int i = 1; i <= number.Length; i++)
//    {
//        count++;
//    }
//    return count;
//}


/* 
=======
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

using System;
using static System.Console;

Clear();
<<<<<<< HEAD
Write("Введите число: ");
*/
/* 1-вариант
int num = int.Parse(ReadLine());
int countNumber = GetCountNumbers(num);
WriteLine($"Количество цифр в числе = {countNumber}");
*/

/* 2-вариант
int num = int.Parse(ReadLine());
WriteLine($"Количество цифр в числе = {GetCountNumbers(num)}");
*/

/* 3-вариант
WriteLine($"Количество цифр в числе = {GetCountNumbers(int.Parse(ReadLine()))}");
*/
/*
int GetCountNumbers(int x)
{
    int count = 0;
    while (x > 0)
    {
        count++;
        x /= 10;
    }
    return count;

 }
*/

/*
using System;
using static System.Console;

Clear();
Write("Факториал числа N ");
int N = int.Parse(ReadLine());
int sum = fakte(N);
WriteLine($"Факториал = {sum}");
int fakte(int num)
{
    int i = 1;
    int count = 1;
    while(count < num)
    {
        count++;
        i *= count;
    } 
    return i;
}
*/

/*
using System;
using static System.Console;
Write("Введите N: ");
WriteLine($"Факториал = {Factorial(int.Parse(ReadLine()))}");
int Factorial(int number)
{
    int p = 1;
    for(int i = 2; number >= i; i++)
    {
        p *= i;
    }
    return p;
}
*/


// cоздание массива
using System;
using static System.Console;

Clear();
WriteLine($"[{String.Join(",", GetBinaryArray(8))}]");
int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0,2);
    }
    return result;
}
