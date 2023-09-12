/*
using System;
using static System.Console;

Clear();
int[] array = GetArray(12, -9, 9);
WriteLine($"Массив [{String.Join(", ", array)}]");
int positiveSum = 0;
int negativeSum = 0;
// способ позволяет только опрасить массив, менять в нем он нечего не может.
foreach(int item in array)
{
    Write($"{item} ");
    if(item > 0)
    {
        positiveSum += item;
    }
    else
    {
        negativeSum += item;
    }
}
WriteLine();
WriteLine($"Сумма положительных элементов {positiveSum}, и сумма отрицательных элементов {negativeSum}");

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}
*/

/*
using System;
using static System.Console;

Write("Количество значений в массиве: ");
int length = int.Parse(ReadLine());
Write("Минимальное значение = ");
int num_min = int.Parse(ReadLine());
Write("Максимальное значение = ");
int num_max = int.Parse(ReadLine());
int[] num_array = GetArray(length, num_min, num_max);
WriteLine($"Полученный массив: [{String.Join(", ", num_array)}]");
int[] rew_result = Revers(length, num_array);
WriteLine($"Реверс массива: [{String.Join(", ", rew_result)}]");

int[] GetArray(int size1, int min1, int max1)
{
    int[] array1 = new int[size1];
    for(int i = 0; i < size1; i++)
    {
        array1[i] = new Random().Next(min1,max1+1);
    }
    return array1;
}

int[] Revers(int size1, int[] rew_array)
{
    int rew = -1;
    for(int j = 0; j < size1; j++)
    {
        rew_array[j] *= rew;
    }
    return rew_array;
}
*/

/*
using System;
using static System.Console;

Clear();
int[] array = GetArray(8, -10, 10);
WriteLine(String.Join(" ", array));
InverseArray(array);
WriteLine(String.Join(" ", array));

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}

void InverseArray(int[] inArray)
{
    for(int i = 0; i < inArray.Length; i++)
    {
        inArray[i] *= -1;
    }

}
*/

using System;
using static System.Console;

Clear();

int[] GetArrayFromString(string stringArray);
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
}













