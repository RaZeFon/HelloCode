//using System;
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
using System;
using static System.Console;

Clear();
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