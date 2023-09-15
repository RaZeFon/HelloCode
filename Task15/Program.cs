/*
using System;
using static System.Console;

Clear();

Write("Введите размер массива: ");
int n = int.Parse(ReadLine());
// сгенерированый массив 
int[] array1 = GetArray(n, 1, 10);
WriteLine(string.Join(" ", array1));
// первый способ реверса
int[] array2 = ReverseArray1(array1);
WriteLine(string.Join(" ", array2));
// второй способ реверса
ReverseArray2(array1);
WriteLine(string.Join(" ", array1));


int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}


//первый метод реверса
int[] ReverseArray1(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}


//метод реверс который нечего не возвращает
void ReverseArray2(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length -1 -i];
        inArray[inArray.Length -1 -i] = k;
    }
}
*/



/*
using System;
using static System.Console;
Clear();
WriteLine("Может ли существовать такой треугольник: ");
Write("Сторона A: ");
int number1 = int.Parse(ReadLine());
Write("Сторона B: ");
int number2 = int.Parse(ReadLine());
Write("Сторона C: ");
int number3 = int.Parse(ReadLine());

void Triangle(int num1, int num2, int num3)
{
    if(num1 + num2 > num3 && num2 + num3 > num1 && num1 + num3 > num2) WriteLine("Да");
    else WriteLine("Нет");
} 

Triangle(number1, number2, number3);
*/

/*
using System;
using static System.Console;

Clear();
Write("Введите стороны треугольника через пробел: ");
string nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
if(isTriangle(int.Parse(nums[0]), int.Parse(nums[1]),int.Parse(nums[2])))
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}

bool isTriangle(int a, int b, int c)
{
    return ((a + b) > c)&&((b + C) > a)&&((c + a) > b);
}
*/


using System;
using System.Xml.XPath;
using static System.Console;
Clear();
WriteLine("Конвертация из 10-системы счисления в 2-систему счисления");
Write("Введитк число: ");
int number = int.Parse(ReadLine());
WriteLine(NumberBinary(number));

string NumberBinary(int num)
{
    string result = string.Empty;
    while (num >= 1)
    { 
        if(num % 2 == 0) 
        {
            num /= 2; 
            result += "0";
        }
        else
        {
            num /= 2;
            result += "1";
        }
    }
    return result;
}
