// Задание 1 Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random random = new Random();
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
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

// bool SearchNum(int[] array, int num)
// {
//     for(int i = 0; i < array.Length; i++)
//     { 
//         if(array[i] == num)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// System.Console.WriteLine("Input size of array: " );
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: " );
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);

// System.Console.WriteLine("Input number: " );
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(SearchNum(myArray, num));



// Задание 2 . Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

// int[] ChangeArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

// System.Console.WriteLine("Input size of array: " );
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: " );
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);
// myArray = ChangeArray(myArray);
// PrintArray(myArray);


// Задание 3. Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5]

// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random random = new Random();
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }
//     return array;
// }

// int[] CompositionArray(int[] array) 
// {
//     int[] resultArray = new int[array.Length / 2];
//     for(int i = 0; i < resultArray.Length; i++) 
//     {
//         resultArray[i] = array[i] * array[array.Length - i - 1];
//     }
//     return resultArray;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " " );
//     }
//     System.Console.WriteLine("");
// }

// System.Console.WriteLine("Input size of array");
// int size = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Input min of array");
// int min = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Input max of array");
// int max = Convert.ToInt32(System.Console.ReadLine());

// int[] myArray = CreateArray(size,min,max);
// PrintArray(myArray);

// PrintArray(CompositionArray(myArray));


