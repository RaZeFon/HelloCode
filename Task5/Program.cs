int num = new Random().Next(10, 99);
Console.WriteLine(num);
int num2 = num / 10;
int num1 = num % 10;
if (num1 > num2)
{
    Console.Write("макс число ");
    Console.WriteLine(num1);
}
else
{
    Console.Write("Макс число ");
    Console.WriteLine(num2);
}