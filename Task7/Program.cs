
//using System;
//using static System.Console;
//Clear();
//Write("Первое число: ");
//int number1 = Int32.Parse(ReadLine());
//Write("Второе число: ");
//int number2 = Int32.Parse(ReadLine());
//int num = number1 / number2;
//int sum = number2 * num;
//if (number1 != sum)
//{
//    int ost = number1 - sum;
//    WriteLine($"{number2} Некратно {number1}, остаток {ost}");
//}
//else
//{
//    WriteLine($"{number2} кратно {number1}");
//}


using System;
using static System.Console;
Clear();
Write("Введите первое число: ");
int a = int.Parse(ReadLine());
Write("Введите второе число: ");
int b = int.Parse(ReadLine());
if(a % b == 0)
{
    WriteLine("кратно");
}
else
{
    WriteLine($"не кратно {a % b}");
}
