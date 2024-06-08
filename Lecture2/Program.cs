// // Задание 1
// Знакомство с Методом(функцией)

// int Max(int arg1, int arg2, int arg3)  //Метод-код отвечает за поиск максимума из трех групп по три числа
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 444;
// int b2 = 56;
// int c2 = 1;
// int a3 = 78;
// int b3 = 159;
// int c3 = 5;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

// Console.WriteLine(max);


// // Задание 2
// // Меняем код , добавляя массивы (изменение кода1)

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result)
//         result = arg2;
//     if (arg3 > result)
//         result = arg3;
//     return result;
// }

// int[] array = { 15, 27, 38, 41, 57, 68, 79, 8, 934 };

// // переменная = max, функция(метод) = Max
// int max = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );

// Console.WriteLine(max);



// // Задание 3.
// // Поиск позиции нужного нам элемента

// int[] array = { 11, 2, 34, 48, 58, 4, 73, 8, 11}; // если 2 числа(элемнта) одинак. числа, то треб. нов. оператор

// int n = array.Length;
// int find = 11;

// int index = 0; // счетчик
// while (index < n)
// {
//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++; // index = index +1
// }


// Задание 4.
// Перепишем код 3, с использованием генератора псевдо-случайных чисел
// с использованием Методов (взять метод, передать в него массив и заполнить массив нужным кол-вом эл-тов)
// + Метод(кот, будет выводить все эл-ты по порядку)
// + Метод (поиск индекса)

void FillArray(int[] collection) // Метод, в кач-ве аргумента() какая-то коллекция
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // Метод, печат. массив
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)  // Метод, возвращающий позиц.(индекс)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; //при нахождении 1го числа , код заканчивает поиск
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; //в массиве по умолч. 10 эл-тов, заполненный 0
// вызываем Методы
FillArray(array); 
PrintArray(array);
Console.WriteLine(); // пустая стр., чтобы отделить позиц. от массива при выводе 
int pos = IndexOf(array, 4); // в кач-ве аргум. массив и пишем,что ищем число 4
Console.WriteLine(pos);
