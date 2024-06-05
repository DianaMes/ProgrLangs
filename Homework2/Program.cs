// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine ("Да");
// }
// else 
// {
//     Console.WriteLine ("Нет");
// }


// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
//  номер координатной четверти плоскости, в которой находится эта точка.

// Console.Write("Введите координаты точки x  ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точки y  ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x>0 && y>0)
// {
//     Console.WriteLine("1");
// }
// if (x<0 && y>0)
// {
//     Console.WriteLine("2");
// }
// if (x<0 && y<0)
// {
//     Console.WriteLine("3");
// }
// if (x>0 && y<0)
// {
//     Console.WriteLine("4");
// }
// else 
// {
//     Console.WriteLine("Точка находится на оси координат");
// }


// Задача 3: Напишите программу, которая принимает на вход целое число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.

// Console.Write("Ведите число:  ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number>9 & number<100)
// {
//     int firstDigit = number/10;
//     int secondDigit = number%10;
//     int maxDigit = firstDigit;
//     if (secondDigit > maxDigit)
//     {
//         maxDigit = secondDigit;
//     }
//     Console.WriteLine($"Максимальная цифра в числе {number} => {maxDigit}");
// }
// else 
// {
//     Console.WriteLine($"Вы ввели неккоректное число {number}");
// }


// Задача 4: Напишите программу, которая на вход принимает натуральное число N,
//  а на выходе показывает его цифры через запятую.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string digits = string.Empty;
while (number > 0)
{
    digits = number % 10 + "," + digits;
    number = number / 10;
}
Console.WriteLine(digits);
