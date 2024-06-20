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


// public class Task4
// {
// public static void Main(string[] args)
// {
// // Входная строка со словами, разделенными пробелами
// string input = "Hello my world";
// // Вызов метода для обращения порядка слов в строке
// string result = ReverseWords(input);
// // Вывод результата
// Console.WriteLine(result);
// }
// // Метод для обращения порядка слов в строке
// public static string ReverseWords(string str)
// {
// // Разделение строки на слова
// string[] words = str.Split(' ');
// // Обращение порядка слов
// Array.Reverse(words);
// // Соединение слов обратно в строку с пробелами
// return string.Join(" ", words);
// }
// }

