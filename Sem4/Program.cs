// Задание 1.
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// int DigitsCounter(int num)
// {
//     int counter = 0;
//     while (num > 0)
//     {
//         num /= 10;
//         counter++;
//     }
//     return counter;
// }

// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(DigitsCounter(num));


// Задание 2.
// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

// int[] InputArray(int size)
// {
//     int[] arr = new int [size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.WriteLine($"Input {i+1} number: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }

// int ArrayCounter(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] % 10 == 1 && arr[i] % 7 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }


// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] arr = InputArray(size);
// System.Console.WriteLine(ArrayCounter(arr));


// Задание 3.
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

// int[] CreateRandomArray(int size){    
//     int[] array = new int[size];
//     Random random = new Random();
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(0, 9 + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int NumberOfArray (int[] array){
//     int number = 0;
//     for(int i =0; i< array.Length; i++) {
//         number += array[i] * (int)Math.Pow(10, array.Length-i-1); 
//     }
//     return number;
// }  

// System.Console.WriteLine("Input size of array");
// int size = Convert.ToInt32(System.Console.ReadLine());



// int[] myArray = CreateRandomArray(size);
// int result = NumberOfArray(myArray);
// PrintArray(myArray);
// Console.WriteLine(result);
