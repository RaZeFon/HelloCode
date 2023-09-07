//using System;
//using static System.Console;
//Clear();
//int number = new Random().Next(100, 1000);
//string num_str = number.ToString();
//string result = num_str[0].ToString() + num_str[2];
//WriteLine($"{number}->{result}");


using System;
using static System.Console;
Clear();
int number = new Random().Next(100, 1000);
int a1 = number / 100;
int a2 = number % 10;
WriteLine($"{number}->{a1*10+a2}");
WriteLine($"{number}->{(number / 100) * 10 + number % 10}");
