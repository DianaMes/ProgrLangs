﻿// int numberA = new Random().Next(1, 10);
// Console.WriteLine(numberA);
// int numberB = new Random().Next(1,10);
// Console.WriteLine(numberB);
// int result = numberA + numberB;
// Console.WriteLine(result);



// Console.Write("Введите имя пользователя: ");
// string username = Console.ReadLine();
// if (username.ToLower() == "disha")
// {
//     Console.WriteLine("Привет, Disha!!!");
// }
// else
// {
//     Console.Write("Привет, ");
//     Console.WriteLine(username);
// }



// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 15;

// int max = a;

// if (a>max) max = a;
// if(b>max) max = b;
// if(c>max) max = c;
// if(d>max) max = d;
// if(e>max) max = e;

// Console.Write("max = ");
// Console.WriteLine(max);



using System.Runtime.InteropServices;

Console.Clear();
int xa = 1, ya = 1,
    xb = 1, yb = 7,
    xc = 30, yc = 7;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

// // System.Console.WriteLine($"Ширина: {Console.BufferWidth}, Высота: {Console.BufferHeight}");



int x = xa, y = xb;
int count = 0;
while (count < 1000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;

}
