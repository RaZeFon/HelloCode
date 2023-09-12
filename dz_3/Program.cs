using System;
using static System.Console;


Clear();
Write("Введите число А: ");
int A = int.Parse(ReadLine());
Write("Введите число B: ");
int B = int.Parse(ReadLine());
WriteLine($"{Stepen1(A,B)}");

int Stepen1(int num1, int num2)
{
    int sum = 1;
    for(int i = 0; i < num2; i++)
    {
        sum *= num1;
    }
    return sum;
}



WriteLine();
WriteLine("Программа для подсчёта суммы цыфр числа: ");
Write("Введите число: ");
int number = int.Parse(ReadLine());
WriteLine($"Результат = {Stepen(number)}");

int Stepen(int num)
{
    int sum = 0;
    int result = 0;
    while(num > 0)
    {
        result = num % 10;
        num /= 10;
        sum += result;
    }
    return sum;
}



WriteLine();
Write("Длина массива: ");
int len = int.Parse(ReadLine());
Write("Min значение: ");
int number1 = int.Parse(ReadLine());
Write("Max значение: ");
int number2 = int.Parse(ReadLine());
WriteLine($"[{String.Join(",", RandomArray(len, number1, number2))}]");

int[] RandomArray(int size, int start, int end)
{
    Random numbers = new Random();
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = numbers.Next(start, end+1);
    }
    return result;
}