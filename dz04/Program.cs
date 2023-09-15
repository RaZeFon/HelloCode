
using System;
using static System.Console;

WriteLine();
Write("Длина массива: ");
int len = int.Parse(ReadLine());
int[] array = RandomArray(len);
WriteLine($"Массив {String.Join(" ", array)}");

WriteLine($"Количество четных чисел: {GetEvenNumbers(array)} ");


int[] RandomArray(int size)
{
    Random numbers = new Random();
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = numbers.Next(100, 1000);
    }
    return result;
}

int GetEvenNumbers(int[] inArray)
{
    int count = 0;
    for(int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}



/*
using System;
using static System.Console;

int[] array = GetArray(5, 1, 10);
WriteLine(String.Join(" ", array));
int sum = PositionIndex(array);
WriteLine($"Сумма элементов на нечетных позициях {sum}");

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int PositionIndex(int[] inArray)
{
    int inSum = 0;
    for (int i = 1; i < inArray.Length; i += 2)
    {
        inSum += inArray[i];
    }
    return inSum;
}
*/

/*
using System;
using static System.Console;
//попытался конвертировать в вещественые значения
Clear();
float min = (float)new Random().Next(1, 10);
float max = (float)new Random().Next((int)min + 1, 20);
WriteLine($"Max = {max} и Min = {min} значения");

float[] array = FloatArray(6, min, max);
WriteLine(String.Join(" ", array));
WriteLine($"Разница между max и min = {max - min}");


float[] FloatArray(int size, float minEl, float maxEl)
{
    float[] result = new float[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = (float)new Random().Next((int)minEl, (int)maxEl + 1);
    }
    return result;
}
*/









