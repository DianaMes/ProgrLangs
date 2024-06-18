// Метод по заполнению двумерного массива

// int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
// {
// int[,] matrix = new int[rows, columns];
// Random random = new Random();
// for (int i = 0; i < rows; i++)
// {
// for (int j = 0; j < columns; j++)
// {
// matrix[i, j] = random.Next(min, max + 1);
// }
// }
// return matrix;
// }
// // 0 8 9 6
// // 1 2 7 4
// // 9 4 1 6
// void PrintMatrix(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// System.Console.Write(matrix[i, j] + " ");
// }
// System.Console.WriteLine();
// }
// }

// PrintMatrix(CreateRandomMatrix(4,6,0,9));


// Задание 1
// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
// 4 3 4 1 =>
// 2 9 5 4
// Обсудить этапы решения задачи
// Оформить этапы в виде функций
// 4 3 16 3
// 4 3 4 1
// 4 9 25 4

int[,] EvenNumsToQuad(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if(i % 2 == 0 && j % 2 == 0)
{
matrix[i, j] = matrix[i, j] * matrix[i, j];
}
}
}
return matrix;
}

int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];
Random random = new Random();
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
{
matrix[i, j] = random.Next(min, max + 1);
}
}
return matrix;
}
// 0 8 9 6
// 1 2 7 4
// 9 4 1 6
void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write(matrix[i, j] + " ", ConsoleColor.Green);
}
System.Console.WriteLine();
}
System.Console.WriteLine();
}

System.Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Input min of array");
int min = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Input max of array");
int max = Convert.ToInt32(System.Console.ReadLine());

int[,] matrix = CreateRandomMatrix(rows, columns, min, max);
PrintMatrix(matrix);
matrix = EvenNumsToQuad(matrix);
PrintMatrix(matrix);


// Задание 2
// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
// 4 3 4 1 => 2 + 3 + 5 = 10
// 2 9 5 4

 int SumOfMainDiagonal(int[,] matrix)
{
int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if(i==j)
{
sum += matrix[i, j];
}
}
}
return sum;
}



// Задание 3
// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

double[] SrAr(int[,] matrix)
{
double[] result = new double[matrix.GetLength(0)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
int sum = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
{
sum += matrix[i, j];
}
result[i] = (double)sum / matrix.GetLength(1);
}
return result;
}

void PrintArray(double[] array)
{
for(int i = 0; i < array.Length; i++)
{
System.Console.Write(array[i] + " " );
}
System.Console.WriteLine("");
}


int[,] matrix = CreateRandomMatrix(rows, columns, min, max);
PrintMatrix(matrix);
PrintArray(SrAr(matrix));