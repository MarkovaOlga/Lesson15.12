// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

int[] SumOfElem(int[,] matrix)
{
    int[] sum1 = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sum1[i] = sum;
    }
    return sum1;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length) Console.WriteLine($"Сумма элементов строки {i} массива -> {arr[i]}");
    }
}

int MinSum(int[] arr)
{
    int minNumber = arr[0];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNumber)
        {
            minNumber = arr[i];
            index = i;
        }
    }
    return index;
}

int[,] matrix1 = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(matrix1);
int[] array = SumOfElem(matrix1);

PrintArray(array);
int result = MinSum(array);
Console.WriteLine($"В строке {result} наименьшая сумма элементов");
