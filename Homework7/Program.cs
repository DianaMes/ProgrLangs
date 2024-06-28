// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// void NaturalNumbers(int M, int N)
//     {
//         if (M > N)
//         {
//             return;
//         }

//         Console.WriteLine(M);
//         NaturalNumbers(M + 1, N);
//     }

// Console.Write("Введите значение M: ");
//     int M = int.Parse(Console.ReadLine());
        
// Console.Write("Введите значение N: ");
//     int N = int.Parse(Console.ReadLine());

// Console.WriteLine("Натуральные числа от M до N:");
//     NaturalNumbers(M, N);

// __________________________________________________________

// Задача 2
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

// int Ackermann(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (m > 0 && n == 0)
//         {
//             return Ackermann(m - 1, 1);
//         }
//         else
//         {
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//         }
//     }

// Console.WriteLine("Введите число m:");
//     int m = int.Parse(Console.ReadLine());
        
// Console.WriteLine("Введите число n:");
//     int n = int.Parse(Console.ReadLine());

// int result = Ackermann(m, n);
// Console.WriteLine($"A({m}, {n}) = {result}");

// ____________________________________________________

// Задача 3
// Задайте произвольный массив. Выведете его элементы, начиная с конца.
//  Использовать рекурсию, не использовать циклы.


void PrintArrayRevers(int[] array, int index)
    {
        if (index < 0) 
        {
            return;
        }
        
        Console.Write(array[index] + " "); 
        PrintArrayRevers(array, index - 1);
    }

int[] array = { 1, 2, 3, 4, 5 };  
PrintArrayRevers(array, array.Length - 1); 
