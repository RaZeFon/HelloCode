//using System;
//using static System.Console;

//Clear();
//Write("Введите число N: ");
//int number_N = int.Parse(ReadLine());
//int index = 1;
//while (index < number_N + 1)
//{
//    double num_count = Math.Pow(index, 2);
//    Write($" {num_count}");
//    index++;
//}


using System;
using static System.Console;

Clear();
Write("Введите N: ");
int N = int.Parse(ReadLine());
for (int i = 1; i <= N; i++)
{
    Write($"{i*i} ");
}
