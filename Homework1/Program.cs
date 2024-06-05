// Задача 1
// Внутри класса Answer напишите метод CompareNumbers, 
// который на вход принимает два числа и выводит, какое число большее, 
// а какое меньшее.

// using System;

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         if (firstNumber == secondNumber)
//         {
//             Console.WriteLine($"Введенные числа равны `{firstNumber}`");
//         }
//         if (firstNumber > secondNumber)
//         {
//             Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
//         }
//         if (firstNumber < secondNumber)
//         {
//             Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
//         }
//     }

//     static public void Main(string[] args) {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//             firstNumber = 5;
//             secondNumber = 6;
//         }

//         CompareNumbers(firstNumber, secondNumber);
//     }
// }


// Задача 2.
// Внутри класса Answer напишите метод FindMax, который принимает на вход 
// три числа и выдаёт максимальное из этих чисел.

// using System;

// public class Answer {
    
//   static int FindMax(int a, int b, int c)
//     {
//       // Введите свое решение ниже
    
//      int max = a;
        
//       if(b > max){
//         max = b;
//       }
//       if(c > max){
//         max = c;
//       }
       
//       return max;
//   }     

//   // Не удаляйте и не меняйте метод Main! 
//   static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            a = 5;
//            b = 0;
//            c = 59;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }


// Задача 3.
// Внутри класса Answer напишите метод CheckIfEven, который на вход 
// принимает число number и выводит, является ли число чётным (делится ли
//  оно на два без остатка).

    // System.Console.WriteLine("Enter a number");
    // int number = Convert.ToInt32(Console.ReadLine());
    // {
      
    //   if((number % 2) == 0)
    //   {
    //     Console.WriteLine($"Число `{number}` чётное");
    //   }
    //   else{
    //     Console.WriteLine($"Число `{number}` нечётное");
    //   }

    // }


    // Задача 4.
    // Внутри класса Answer напишите метод PrintEvenNumbers, которая 
    // на вход принимает число (number), а на выходе выводит все чётные 
    // числа от 1 до number (включительно), после каждого числа должен 
    // быть знак пробела.

System.Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());

for (int count = 2; count <= num; count += 2)
{
    Console.Write($"{count}\t");
}