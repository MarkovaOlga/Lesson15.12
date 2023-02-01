// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

// int[,] NewMatrix(int[,] matrix)
// {
//     int[,] matrixnew = new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrixnew[i, j] = matrix[j, i];
//         }
//     }
//     return matrixnew;
// }
void NewMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0)-1; i++)
    {
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}
int rows1 = 5;
int columns1 = 5;
int minvalue = 1;
int maxvalue = 10;

int[,] matrix1 = CreateMatrixRndInt(rows1, columns1, minvalue, maxvalue);
PrintMatrix(matrix1);
if (rows1 == columns1)
{
    Console.WriteLine();
    NewMatrix(matrix1);
    //int[,] matrix2 = NewMatrix(matrix1);
    PrintMatrix(matrix1);
}
else Console.WriteLine("Введено разное количество строк и столбцов.Введите одиноковые цифры");