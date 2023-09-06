//Решение задачи построино на линейных алгоритмах работы программ.

//Console.Clear();
//Console.Write("Введите число: ");
//int number = int.Parse(Console.ReadLine());
//int sqr = number * number;
//Console.WriteLine($"Квадрат числа = {sqr}");


//Второе решение основываеться на использовании стандартных математических библиотек.
//int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
//Console.WriteLine($"Квадрат числа = {sqr1}");


Console.Clear();
Console.Write("Введите первое число: ");
int number_c2 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_1 = int.Parse(Console.ReadLine());
int num_squar = number_1 * number_1;
if(num_squar == number_c2)
    {
        Console.WriteLine("Первое число является квадратом второго");
    }
else
    {
        Console.WriteLine("Не является квадратом числа");
    }
