// Задача 35. Задайте одномерный массив из 123 случайных чисел.
// найдите количество элементов массива, значения которых лежат в отрезке [10,99]
// пример для массива из 5,а не 123 элементов
// [5, 18, 123, 6, 2] -> 1

int[] array = CreateArrayRndInt(123, -50, 150);
PrintArray(array);
Console.WriteLine(Numbers(array, 10, 99));

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int Numbers(int[] arr, int begin, int end)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i] >= begin && array[i] <= end) count++;
    }
    return count;
}