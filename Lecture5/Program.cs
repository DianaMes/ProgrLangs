// void OpenMatryoshka(int size)
// {
//     Console.WriteLine($"Opening matryoshka of size {size}...");
//     if (size == 1)
//     {
//         Console.WriteLine("Reached the smallest matryoshka!");
//         return;
//     }
//     OpenMatryoshka(size - 1);
// }

// OpenMatryoshka(5);

// _____________________________________________________________________

// Задача 1:
// Вычислить факториал от натур. числа N

int Fact(int n)
{
    if(n == 1 || n == 0)
    {
        Console.WriteLine($"Stop: {n}");
        return 1;
    }
    Console.WriteLine(n);
    return n * Fact(n - 1);
}
Console.Write(Fact(5));