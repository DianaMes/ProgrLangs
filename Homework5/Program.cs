﻿// Задание 1
// Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого 
// элемента нет: "Позиция по рядам выходит за пределы массива"
// или
// "Позиция по колонкам выходит за пределы массива"

// Позиции в массиве считать от единицы.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Объявление двумерного массива
//         int[,] numbers = new int[,] {
//             {1, 2, 3, 4},
//             {5, 6, 7, 8},
//             {9, 10, 11, 12}
//         };

//         // Переменная для хранения позиции элемента по рядам
//         int row = 3; // Предположим, что пользователь хочет получить элемент на второй строке
//         // Переменная для хранения позиции элемента по столбцам
//         int col = 4; // Предположим, что пользователь хочет получить элемент во втором столбце

//         // Проверка, если позиция по рядам выходит за пределы массива
//         if (row < 1 || row > numbers.GetLength(0))
//         {
//             Console.WriteLine("Позиция по рядам выходит за пределы массива");
//             return; // Завершаем выполнение программы, так как элемент не найден
//         }

//         // Проверка, если позиция по столбцам выходит за пределы массива
//         if (col < 1 || col > numbers.GetLength(1))
//         {
//             Console.WriteLine("Позиция по колонкам выходит за пределы массива");
//             return; // Завершаем выполнение программы, так как элемент не найден
//         }

//         // Вывод значения элемента, если он находится в пределах массива
//         Console.WriteLine($"Значение элемента на позиции ({row}, {col}) равно {numbers[row - 1, col - 1]}");
//     }
// }


using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Поиск элемента по позициям
    public static int FindElementByPosition(int[,] array, int x, int y)
    {
         // Проверяем, что обе координаты находятся в пределах массива
        if (ValidatePosition(array, x, y))
        {
            // Возвращаем значение элемента по координатам
            return array[x - 1, y - 1];
        }
        else
        {
            // Если элемент не найден, возвращаем -1
            return -1;
        }//Напишите свое решение здесь
    }

// Проверка позиций на вхождение в массив
    public static bool ValidatePosition(int[,] array, int x, int y)
    {
        // Проверяем, что обе координаты находятся в пределах массива
        return x > 0 && x < array.GetLength(0) && y > 0 && y < array.GetLength(1);
      //Напишите свое решение здесь
    }

    public static void PrintResult(int[,] numbers, int x, int y)
    {
        // Получаем значение элемента
        int elementValue = FindElementByPosition(numbers, x, y);

        // Проверяем, был ли элемент найден
        if (elementValue != -1)
        {
            // Печатаем значение элемента
            Console.WriteLine(elementValue);
        }
        else
        {
            // Если элемент не найден, печатаем соответствующее сообщение
            Console.WriteLine("Позиция по колонкам выходит за пределы массива");
        }
      //Напишите свое решение здесь
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {   
        int[,] array;

        int x, y;

        if (args.Length >= 3)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            array = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        array[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }

            // Парсинг x и y из аргументов
            if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
            {
                // Теперь у вас есть двумерный массив "array" и координаты x и y
                UserInputToCompileForTest.PrintResult(array, x, y);
            }
            else
            {
                Console.WriteLine("Error parsing x or y to an integer.");
            }
        }
        else
        {
           
            // Если аргументов на входе нет, используем примерный массив
            array = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
            x = 2;
            y = 2;
            
            UserInputToCompileForTest.PrintResult(array, x, y);

        }                
    }
}