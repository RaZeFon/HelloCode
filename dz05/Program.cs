using System;
using static System.Console;

Clear();
Write("Введите числа через пробел: ");
int[] array = GetArrayFromString(Readline());


int[] GetArrayFromString(string strArray)
{
    string StrNums = strArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[StrNums.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] Convert.ToInt32(StrNums[i]);
    }
    return result;
}

int[] AboveZero(int[] inArray)
{
    int count = 0;
     
}