//using System;
//using static System.Console;

//Clear();
//Write("Введите число: ");
//int number = int.Parse(ReadLine());
//if (number % 7 == 0)
//{
//    if (number % 23 == 0)
//    {
//        WriteLine("Да");
//    }
//    if (number % 23 != 0)
//    {
//        WriteLine("Нет");
//    }
//}
//else
//{
//    WriteLine("Нет");
//}


using System;
using static System.Console;

Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine());
if ((number % 7 == 0)&&(number % 23 == 0))
{
    WriteLine($"{number}->Да");
}
else
{
    WriteLine($"{number}->Нет");
}

