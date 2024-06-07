// // Задание 1.
// // Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива,
// //  значения которых лежат в отрезке [10,90].
// // Начальные условия:
// // int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива


// using System;
// using System.Linq;
// class UserInputToCompileForTest
// {
//     public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
//     {
//         // Инициализация счетчика найденных элементов
//     int count = 0;

//     // Перебор всех элементов массива
//     foreach (int number in numbers) {
//         // Проверка, находится ли текущий элемент в заданном диапазоне
//         if (number >= minRange && number <= maxRange) {
//             // Увеличение счетчика, если элемент попадает в диапазон
//             ++count;
//         }
//     }
//     // Возврат количества элементов в диапазоне
//     return count;
//     }

//     public static void PrintResult(int[] array)
//     {
//         int count = 0; // Счетчик для подсчета элементов в отрезке [10, 90]
//         foreach (int num in array)
//         {
//             if (num >= 10 && num <= 90)
//             {
//                 count++; // Увеличиваем счетчик, если элемент попадает в отрезок
//             }
//         }
//         Console.WriteLine($"Количество элементов в отрезке [10, 90]: {count}");

//     }
// }

// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;


//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();

//             // Теперь arr содержит преобразованные в целые числа из командной строки

//         } else {
//            // Если аргументов на входе нет
//             array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }



// // Задание 2.
// // Задайте массив на 10 целых чисел. Напишите программу, которая определяет
// //  количество чётных чисел в массиве.

// using System;
// using System.Linq;

// class UserInputToCompileForTest
// {
//     public static int CountEvenItems(int[] numbers)
//     {
//         int evenCount = 0; // Счетчик для подсчета четных чисел

//         // Проверяем каждый элемент массива
//         foreach (int number in numbers)
//         {
//             // Если число четное, увеличиваем счетчик
//             if (number % 2 == 0)
//             {
//                 evenCount++;
//             }
//         }

//         return evenCount; // Возвращаем количество четных чисел
//     }

//     public static void PrintResult(int[] array)
//     {
//         int evenCount = CountEvenItems(array); // Вызов метода подсчета четных чисел
//         Console.WriteLine(evenCount); // Вывод результата
//     }

//     //Не удаляйте и не меняйте класс Answer!
//     class Answer
//     {
//         public static void Main(string[] args)
//         {
//             int[] array;


//             if (args.Length >= 1)
//             {
//                 // Объединяем все аргументы командной строки в одну строку
//                 string joinedArgs = string.Join(" ", args);

//                 // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//                 array = joinedArgs.Split(", ")
//                                       .Select(int.Parse)
//                                       .ToArray();

//                 // Теперь arr содержит преобразованные в целые числа из командной строки

//             }
//             else
//             {
//                 // Если аргументов на входе нет
//                 array = new int[] { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 }; // Создание массива
//             }
//             UserInputToCompileForTest.PrintResult(array);
//         }
//     }
// }



// Задание 3.
// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу
//  между максимальным и минимальным элементов массива.
// Начальные условия:
//      int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива


using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Разница между максимальным и минимальным элементами массива
    
    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        // Переменная для хранения минимального значения
        double minValue = double.MaxValue; // Инициализируем максимально возможным значением double

        // Проходим по всем элементам массива
        for (int i = 0; i < numbers.Length; i++)
        {
            // Если текущее значение меньше текущего минимального, обновляем минимальное значение
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
            }
        }

        // Возвращаем найденное минимальное значение
        return minValue;
    }

    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
        // Переменная для хранения максимального значения
        double maxValue = double.MinValue; // Инициализируем минимально возможным значением double

        // Проходим по всем элементам массива
        for (int i = 0; i < numbers.Length; i++)
        {
            // Если текущее значение больше текущего максимального, обновляем максимальное значение
            if (numbers[i] > maxValue)
            {
                maxValue = numbers[i];
            }
        }

        // Возвращаем найденное максимальное значение
        return maxValue;
    }

    public static void PrintResult(double[] array)
    {
        double minValue = FindMin(array);
        double maxValue = FindMax(array);

        Console.WriteLine(maxValue - minValue);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        double[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(double.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}