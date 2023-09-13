using System;
using static System.Console;

WriteLine();
Write("Длина массива: ");
int len = int.Parse(ReadLine());

WriteLine($"[{String.Join(",", RandomArray(len))}]");

int[] RandomArray(int size)
{
    Random numbers = new Random();
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = numbers.Next(100, 1000);
    }
    return result;

    int count = 0;
    for(int j = 0; j < size; j++)
    {
        
        if (result[j] % 2 == 0)
        {
            count++;
        }
         return count;
    }
}
