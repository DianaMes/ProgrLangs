// Задача 1
// Создать двумерный массив с размерами 3х5, состоящий из целых чисел
// Вывести его элементы на экран


// int[,] CreateMatrix(int rowCount, int columsCount)  // (число строк, число столбцов)
// {
//     int[,] matrix = new int[rowCount, columsCount];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++) //данный цикл позвол. обратиться к очередному одномерн. массиву
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) //обращен. к эл-там одном. массива
//         {
//             matrix[i, j] = rnd.Next(1, 11);
//         }
//     }
//     return matrix;
// }

// void ShowMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine(); // для отображ. массива в виде таблицы
// }
// }

// int[,] matrix = CreateMatrix(4, 5);
// ShowMatrix(matrix);



//Задача 2 
// Назовем число "Интересным", если его сумма цифр четная
// Создать двумерный массив, состоящий из целых чисел. 
// Вывести на экран "интересные" эл-ты массива


// int[,] CreateMatrix(int rowCount, int columsCount)  // (число строк, число столбцов)
// {
//     int[,] matrix = new int[rowCount, columsCount];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++) //данный цикл позвол. обратиться к очередному одномерн. массиву
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) //обращен. к эл-там одном. массива
//         {
//             matrix[i, j] = rnd.Next(1, 1000);
//         }
//     }
//     return matrix;
// }

// void ShowMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine(); // для отображ. массива в виде таблицы
// }
// }

// int[,] matrix = CreateMatrix(3, 4);
// ShowMatrix(matrix);
// foreach (int e in matrix)
// {
//     if (IsInteresting(e) == true)
//     {
//         Console.WriteLine(e);
//     }
// }

// bool IsInteresting(int value)
// {
//     int sumOfDigits = GetSumOfDigits(value);
//     if (sumOfDigits % 2 == 0)
//     {
//         return true;
//     }
//     return false;
    
// }

// int GetSumOfDigits(int value)
// {
//     int sum = 0;
//     while(value > 0)
//     {
//         sum = sum + value % 10;
//         value = value / 10;
//     }
//     return sum;
// }


// Задача №3
// Считать с консоли строку, состоящую иp цифр и латинских букв.
// Сформировать новую строку, состоящую из букв исходной строки.

// string GetLettersFromString(string s)
// {
//     string letters = "";
//     foreach(char e in s)
//     {
//         if(char.IsAsciiLetter(e) == true)
//         {
//             letters = letters + e;
//         }
//     }
//     return letters;
// }

// string str = Console.ReadLine();
// string result = GetLettersFromString(str);
// Console.WriteLine(result);


// Задача 4
// Считать с консоли строку, состоящую из цифр и
// латинских букв. Сформировать массив, состоящий
// из цифр этой строки.
// Пример
// abc123def06g => [1, 2, 3, 0, 6]

using System;

class Program
{
    static void Main()
    {
        // Считываем строку с консоли
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();
        
        // Вызываем функцию для получения массива цифр
        int[] digitsArray = GetDigitsFromString(input);
        
        // Выводим результат
        foreach (int digit in digitsArray)
            Console.Write($"{digit} ");
        Console.WriteLine();
    }
    
    // Функция для получения массива цифр из строки
static int[] GetDigitsFromString(string str)
{
    // Массив для хранения цифр
    int[] digits = new int[0];

    // Перебираем символы строки
    for (int i = 0; i < str.Length; i++)
    {
        // Проверяем, является ли символ цифрой
        if (char.IsDigit(str[i]))
        {
            // Увеличиваем размер массива, если необходимо
            Array.Resize(ref digits, digits.Length + 1);

            // Преобразуем символ в число и добавляем в массив
           digits[digits.Length - 1] = Convert.ToInt32(char.GetNumericValue(str[i]));

            // Удаляем цифру из строки
            str = str.Remove(i, 1);
            i--; // Сдвигаем индекс, так как длина строки уменьшилась
        }
    }

    return digits;
}

}
