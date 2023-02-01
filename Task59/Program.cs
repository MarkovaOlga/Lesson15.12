// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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

int[] IndexMinVal(int[,] matrix)
{
    int min = matrix[0, 0];
    int indexrow = 0;
    int indexcolumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexrow = i;
                indexcolumn = j;
            }
        }

    }
    return new int[] { indexrow, indexcolumn, min };
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
}

int[,] RemooveCrossColumns(int[,] matrix, int remooverow, int remoovecolumn)
{
    int[,] newmatrix = new int[matrix.GetLongLength(0) - 1, matrix.GetLongLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newmatrix.GetLength(0); i++)
    {
        if (i == remooverow) m++;
        for (int j = 0; j < newmatrix.GetLength(1); j++)
        {
            if (j == remoovecolumn) n++;
            newmatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newmatrix;
}

int[,] matrix1 = CreateMatrixRndInt(5, 4, -10, 10);
PrintMatrix(matrix1);
int[] indexminval = IndexMinVal(matrix1);
PrintArray(indexminval);
Console.WriteLine();
int[,] currentarray = RemooveCrossColumns(matrix1, indexminval[0], indexminval[1]);
PrintMatrix(currentarray);
