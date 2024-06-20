// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.


// char[,] charArray = {
//     { 'H', 'e', 'l', 'l', 'o', '!'},
//     { ' ', 'D', 'i', 's', 'h', 'a'},
// };

// string result = string.Empty;
// for (int i = 0; i < charArray.GetLength(0); i++) 
// {
//     for (int j = 0; j < charArray.GetLength(1); j++) 
//     {
//         result += charArray[i, j];
//     }
// }

// Console.WriteLine(result);

// ___________________________________________________________

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// using System;

// class Program
// {
//     static void Main()
//     {
        
//         Console.Write("Введите строку: ");
//         string input = Console.ReadLine();

       
//         for (int i = 0; i < input.Length; i++)
//         {
//             char currentChar = input[i];
            
          
//             if (currentChar >= 'A' && currentChar <= 'Z')
//             {
                
//                 char lowerCaseChar = (char)(currentChar + ('a' - 'A'));
//                 Console.Write(lowerCaseChar);
//             }
//             else
//             {
                
//                 Console.Write(currentChar);
//             }
//         }
//         Console.WriteLine(); 
//     }
// }

// _______________________________________________________________

// Задача 3
// Задайте произвольную строку. Выясните, является ли она палиндромом.

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите строку для проверки:");
//         string input = Console.ReadLine();

//         if (IsPalindrome(input))
//         {
//             Console.WriteLine("Это строка является палиндромом.");
//         }
//         else
//         {
//             Console.WriteLine("Это строка не является палиндромом.");
//         }
//     }

//     static bool IsPalindrome(string str)
//     {
//         // Удаляем все пробелы из строки и приводим к нижнему регистру
//         str = str.Replace(" ", "").ToLower();

//         // Проверяем палиндром
//         for (int i = 0; i < str.Length / 2; i++)
//         {
//             if (str[i] != str[str.Length - 1 - i])
//             {
//                 return false;
//             }
//         }
//         return true;
//     }
// }

// _______________________________________________________________

// Задача 4
// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.


using System;

class Program
{
    static void Main()
    {
        // Исходная строка с словами, разделенными пробелами
        string inputString = "Летом деревне в Хорошо";

        // Вызываем метод, который переворачивает слова в строке
        string reversedWordsString = ReverseWords(inputString);

        // Выводим результат
        Console.WriteLine("Исходная строка: ");
        Console.WriteLine(inputString);
        Console.WriteLine();
        Console.WriteLine("Строка с перевернутыми словами: ");
        Console.WriteLine(reversedWordsString);
    }

    static string ReverseWords(string input)
    {
        // Разделяем строку на слова по пробелам
        string[] words = input.Split(' ');

        // Создаем массив для хранения перевернутых слов
        string[] reversedWords = new string[words.Length];

        // Идем по словам в обратном порядке и записываем их в новый массив
        for (int i = 0; i < words.Length; i++)
        {
            reversedWords[i] = words[words.Length - 1 - i];
        }

        // Соединяем слова в строку с пробелами и возвращаем результат
        return string.Join(" ", reversedWords);
    }
}

