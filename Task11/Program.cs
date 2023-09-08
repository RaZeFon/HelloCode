//using System;
//using static System.Console;

//Clear();
//Write("Введите координатную четверть: ");
//int quarter = int.Parse(ReadLine());
//if (quarter == 1)
//{
//    WriteLine("x = 1 до бесконечности");
//    WriteLine("y = 1 до бесконечности");
//}
//if (quarter == 2)
//{
//    WriteLine("x = -1 до минус бесконечности");
//    WriteLine("y = 1 до бесконечности");
//}
//if (quarter == 3)
//{
//    WriteLine("x = -1 до минус бесконечности");
//    WriteLine("y = -1 до минус бесконечности");
//}
//if (quarter == 4)
//{
//    WriteLine("x = 1 до бесконечности");
//    WriteLine("y = -1 до минус бесконечности");
//}


//             ^ y
//             |
//      2      |       1
//             |
//---------------------------->
//             |             x
//      3      |       4
//             |
//             |  


using System;
using static System.Console;

Clear();
Write("Введите номер четверти: ");
int n = int.Parse(ReadLine());
switch(n)
{
    case 1:
    {
        WriteLine("x > 0,  y > 0");
        break;
    }
    case 2:
    {
        WriteLine("x < 0,  y > 0");
        break;
    }
    case 3:
    {
        WriteLine("x < 0,  y < 0");
        break;
    }
    case 4:
    {
        WriteLine("x > 0,  y < 0");
        break;
    }
    default:
    {
        WriteLine("Неверная четверть");
        break;
    }
}