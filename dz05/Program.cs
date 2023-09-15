/*
using System;
using static System.Console;

Clear();
Write("Введите числа через пробел: ");
int[] array = GetArrayFromString(ReadLine());
WriteLine($"Количество чисел больше нуля = {AboveZero(array)}");

int[] GetArrayFromString(string strArray)
{
    string[] StrNums = strArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[StrNums.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Convert.ToInt32(StrNums[i]);
    }
    return result;
}

int AboveZero(int[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if(inArray[i] > 0) count++;
    }
    return count;
}
*/


using System;
using static System.Console;

Clear();
Write("Ведите значение b1 = ");
double b1 = double.Parse(ReadLine());
Write("Ведите значение k1 = ");
double k1 = double.Parse(ReadLine());
Write("Ведите значение b2 = ");
double b2 = double.Parse(ReadLine());
Write("Ведите значение k2 = ");
double k2 = double.Parse(ReadLine());

double x1 = (b1 + (b2 * -1)) / (k2 + (k1 * -1));
double y1 = b1 * x1 + k1;
WriteLine($"x = {x1}, y = {y1}");