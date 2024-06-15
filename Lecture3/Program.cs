// Вид 1
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// // Method1(); // вызов метода1 

// Вид 2
// void Method2(string msg) //принимает какое-то кол-во аргументов
// {
//     Console.WriteLine(msg);
// }
// // Method2(msg: "Текст сообщения");

// void Method21(string msg, int count) 
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++; //инкримент
//     }
// }
// // Method21("Текст", 3);
// Method21(count: 3, msg: "другая версия");

// Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3(); // идентифицировали рез-т работы метода в переменную
// Console.WriteLine(year);

// Вид 4

// string Method4(int count, string text) // строку С друг за дружкой выводить Count раз
// {
//     int i = 0;
//     string result = String.Empty;

//         while (i < count)
//         {
//             result = result + text;
//             i++;
//         }
//         return result;
// }
// string res = Method4(5, "hello" + " ");
// Console.WriteLine(res);

// Добавляем цикл FOR

// string Method4(int count, string text) 
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++ ) // инициализация счетч; проверка условия; инкримент
//     {
//         result = result + text;  
//     }
//     return result;
// }
// string res = Method4(5, "mur" + " ");
// Console.WriteLine(res);


// Цикл в цикле(табл. умнож)

// for(int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}"); // интерполяция
//     }
//     Console.WriteLine();
// }

// Задача ==== работа с текстом:
// Дан текст, в тексте нужно все пробелы заменить черточками, мал. буквы "к" заменить "К",
// большие "C" заменить "c"

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгерода, "
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю? ";

// // strind s = "qwerty"
// //             012
// // s [3] // r 

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for(int i = 0; i < length; i++) // пробегает от 0 символа до конца строчки, делая следующ. действия:
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//      return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);


// =======================================
// Задача - Упорядочивание данных внутри массива

int[] arr = { 6, 8, 3, 2, 1, 4, 5, 7, 8, 2 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortMin(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;


        }



        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}

void SelectionSortMax(int[] array) {
    for (int i = 0; i < array.Length - 1; i++) {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++) {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}





PrintArray(arr);
SelectionSortMin(arr);
PrintArray(arr);
SelectionSortMax(arr);
PrintArray(arr);


