//using System;
//using static System.Console;

//Clear();
//Write("Введите число А: ");
//int number_1 = int.Parse(ReadLine());
//Write("Введите чило B: ");
//int number_2 = int.Parse(ReadLine());
//if (number_1 * number_1 == number_2)
//{
//    WriteLine($"B={number_2} квадрат A={number_1}");
//}
//if (number_2 * number_2 == number_1)
//{
//    WriteLine($"A={number_1} квадрат B={number_2}");
//}
//else
//{
//    WriteLine("не является");
//}


using System;
using static System.Console;

Clear();
Write("Введите А: ");
int A = int.Parse(ReadLine());
Write("Введите B: ");
int B = int.Parse(ReadLine());

if (A * A == B)
{
    WriteLine("В является квадратом А");
}
else
{
    if (Math.Pow(B, 2) == A)
    {
        WriteLine("А является квадратом В");
    }
    else
    {
        WriteLine("не являеться");
    }
}