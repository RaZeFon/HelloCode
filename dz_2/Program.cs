using System;
using static System.Console;

//Задача 10
Clear();
Write("Введите трехзнчное число: ");
int number = int.Parse(ReadLine());
Write("Вторая цифра: ");
WriteLine((number / 10) % 10);


//Задача 13
WriteLine(" ");
Write("Введите число: ");
int number1 = int.Parse(ReadLine());
if (number1 < 100)
{
    WriteLine("третьей цифры нет");
}
else
{
    string num_str = number1.ToString();
    string num_str_3 = num_str[2].ToString();
    WriteLine($"{number1}->{num_str_3}");
}


//Задача 15
WriteLine(" ");
Write("Введите число дня недели: ");
int day = int.Parse(ReadLine());
if ((day > 0)&&(day < 6))
{
    WriteLine("Будний день");
}
else
{
    if ((day > 5)&&(day < 8))
    {
        WriteLine("Выходной день");
    }
    else
    {
        WriteLine("Неверное значение");
    }
}