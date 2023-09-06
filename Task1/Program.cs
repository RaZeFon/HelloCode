//using System;
//Console.Clear();
//Console.Write("Введите A:  ");
//int A = int.Parse(Console.ReadLine());
//Console.Write("Введите B:  ");
//int B = int.Parse(Console.ReadLine());
//if (B * B == A)
//{
//    Console.WriteLine("A является квадратом B");
//}
//else
//{
//    Console.WriteLine("A не является квадратом B");
//}


Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if(num == 1)
{
    Console.WriteLine("Понедельник");
}
if(num == 2)
{
    Console.WriteLine("Вторник");
}
if(num == 3)
{
    Console.WriteLine("Среда");
}
if(num == 4)
{
    Console.WriteLine("Четверг");
}
if(num == 5)
{
    Console.WriteLine("Пятница");
}
if(num == 6)
{
    Console.WriteLine("Суббута");
}
if(num == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Нет значения");
}