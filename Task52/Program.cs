﻿// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

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

double[] ArithmeticMeanColumns(int[,] matrix)
{
    double[] arithmeancolum = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        arithmeancolum[j] = sum / matrix.GetLength(0);
        arithmeancolum[j] = Math.Round(arithmeancolum[j], 2);
    }
    return arithmeancolum;
}

void PrintArray(double[] arr)

{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int[,] matrix1 = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(matrix1);
double[] array = ArithmeticMeanColumns(matrix1);
PrintArray(array);



