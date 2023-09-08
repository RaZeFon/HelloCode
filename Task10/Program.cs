using System;
using static System.Console;

Clear();
Write("Введите координату X: ");
int x = int.Parse(ReadLine());
Write("Введите координату Y: ");
int y = int.Parse(ReadLine());

if ( x > 0 && y > 0)
{
    WriteLine("1 координатная четверть");
}
if ( x < 0 && y > 0)
{
    WriteLine("2 координатная четверть");
}
if ( x < 0 && y < 0)
{
    WriteLine("3 координатная четверть");
}
if ( x > 0 && y < 0)
{
    WriteLine("4 координатная четверть");
}


//             ^ y
//             |
//      2      |       1
//             |
//---------------------------->
//             |             x
//      3      |       4
//             |
//             |  