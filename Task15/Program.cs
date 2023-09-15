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

/*
using System;
using System.Xml.XPath;
using static System.Console;
Clear();
WriteLine("Конвертация из 10-системы счисления в 2-систему счисления");
Write("Введите число в десятичной системе: ");
int number = int.Parse(ReadLine());
string StrNumber = NumberBinary(number);
//WriteLine(NumberBinary(number));
WriteLine($"результат в двоичной системе: {ReverseString(StrNumber)}");

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

string ReverseString(string BinNum)
{
    string result = string.Empty;
    for (int i = 0; i < BinNum.Length; i++)
    {
        result += BinNum[BinNum.Length -1 -i];
    }
    return result;
}
*/

/*
//этот знает только 2, 4, 8, 16 системы счисления
using System;
using static System.Console;

Clear();
Write("Введите число: ");
int n = int.Parse(ReadLine());

string s1 = Convert.ToString(n, 2);
WriteLine(s1);
*/

/*
using System;
using static System.Console;

Clear();
Write("Введите число: ");
int n = int.Parse(ReadLine());
Write("Введите систему счисления: ");
int SysNum =int.Parse(ReadLine());
string s2 = DecToNums(n, SysNum);
WriteLine($"Результат: {s2}");

string DecToNums(int number, int sys)
{
    string result = "";
    string chars = "0123456789ABCDEF";
    while(number > 0)
    {
        int k = number / sys;
        int ost = number - k * sys;
        result = chars[ost].ToString() + result;
        number /= sys;
    }
    return result;
}
*/

/*
using System;
using static System.Console;

Clear();
Write("Введите N: ");
int n = int.Parse(ReadLine());
PrintNumber(0, 1, n);

void PrintNumber(int a1, int a2, int size)
{
    Write($"{a1} {a2} ");
    for(int i = 0; i < size -2; i++)
    {
        Write($"{a1 + a2} ");
        int k = a1 + a2;
        a1 = a2;
        a2 = k;
    }
}
*/

/*
using System;
using static System.Console;

Clear();
int[] array1 = {3, 44, 27, 5, 7};
int[] array2 = inCopyArray(array1);
WriteLine($"Массив B [{string.Join(", ", array2)}] копия Массива А [{string.Join(", ", array1)}]");


int[] inCopyArray(int[] inArray)
{
    int[] R_array = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        R_array[i] = inArray[i];
    }
    return R_array;    
}
*/

// что бы скопировать массив его нужно копировать по элементно
using System;
using System.Reflection.Metadata.Ecma335;
using static System.Console;

Clear();
WriteLine("Введите массив через пробел: ");
int[] array = GetArrayFromString(ReadLine());
int[] ArrayCopy = CopyArray(array);
WriteLine(String.Join(" ", ArrayCopy));

int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for( int i = 0; i < result.Length; i++)
    {
        result[i] = inArray[i];
    }
    return result;
}

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Convert.ToInt32(nums[i]);
    }
    return result;
}



