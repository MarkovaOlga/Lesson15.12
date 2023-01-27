// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1   4   8   19
// 5  -2   33  -2
// 77  3   8    1

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];// <- [rows,colums] похоже на массив [0,1], в 13 строчке ссылаемся на 0(колисество строк), а во втором цикле for  на 1(количество столбцов)
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)// 0 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1); //0 - 0, 0-1,0-2,0-3
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}"); // ,5 - количество отступов,чтобы получилась красивая таблица 
            else Console.Write($"{matrix[i, j], 5}  ");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -99, 99);
PrintMatrix(array2D);