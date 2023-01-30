// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента нет в массиве


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

bool IsExistElements(int rows, int columns, int[,] matrix)
{
    return rows <= matrix.GetLength(0) && columns <= matrix.GetLength(1);
}

Console.WriteLine("Укажите строку элемента в массиве: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите столбец элемента в массиве: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

if (rows1 <= 0 || columns1 <= 0)
    Console.WriteLine("Вы ввели 0 или отрицательное число. Введите числа больше 0.");
else
{
    int[,] matrix1 = CreateMatrixRndInt(7, 6, -99, 99);
    PrintMatrix(matrix1);
    Console.WriteLine(IsExistElements(rows1, columns1, matrix1) ? $"Элемент в массиве со строкой {rows1} и столбцом {columns1} -> {matrix1[rows1 - 1, columns1 - 1]}" : "Такого элемента нет в массиве");
}
