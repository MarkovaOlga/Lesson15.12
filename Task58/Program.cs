// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
int[,] MultMatrix(int[,] matrix01, int[,] matrix02)
{
    int[,] multMatrix = new int[matrix01.GetLength(0), matrix02.GetLength(1)];
    for (int i = 0; i < multMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multMatrix.GetLength(1); j++)
        {
            int newnumber = 0;
            for (int n = 0; n < multMatrix.GetLength(1) - 1; n++)
            {
                newnumber += matrix01[i, n] * matrix02[n, j];
            }
            multMatrix[i, j] = newnumber;
        }

    }
    return multMatrix;
}
int row1 = 4;
int column1 = 3;
int row2 = 3;
int column2 = 4;
int min = 1;
int max = 10;

int[,] matrix1 = CreateMatrixRndInt(row1, column1, min, max);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt(row2, column2, min, max);
PrintMatrix(matrix2);
Console.WriteLine();
if (column1 == row2)
{
    int[,] matrix3 = MultMatrix(matrix1, matrix2);
    PrintMatrix(matrix3);
}
else Console.WriteLine("Данные матрицы перемножить нельзя!");