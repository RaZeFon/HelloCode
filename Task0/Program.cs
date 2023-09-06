//Решение задачи построино на линейных алгоритмах работы программ.

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine($"Квадрат числа = {sqr}");


//Второе решение основываеться на использовании стандартных математических библиотек.
int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа = {sqr1}");

