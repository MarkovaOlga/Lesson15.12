// Задача 37. найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// результат запишите в новом массиве
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21

int[] array = CreateArrayRndInt(9);
PrintArray(array);
int[] newArray = CountArray(array);
Console.WriteLine();
PrintArray(newArray);

int[] CountArray(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 == 1) size += 1;
    int[] mult = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i != arr.Length - 1 - i)
            mult[i] = arr[i] * arr[arr.Length - 1 - i];
        else mult[i] = arr[i];
        // if (arr.Length %2==1)
        //   mult[mult.Length -1] = arr[arr.Length/2]; другой вариант 
    }
    return mult;
}
    int[] CreateArrayRndInt(int size)
    {
        int[] arr = new int[size];
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(-20, 10);
        }
        return arr;
    }

void PrintArray(int[] arr)

    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < arr.Length - 1) Console.Write(arr[i] + " ");
            else Console.Write(arr[i]);
        }
        Console.WriteLine("]");
    }


    // Метод для создания массива вещественных цифр

    
    // double[] CreateArrayRndDouble(int size, int min, int max)
    // {
    //     double[] arr = new double[size];
    //     Random rnd = new Random();
    //     for (int i = 0; i < arr.Length; i++)
    //     {
    //         double num =rnd.NextDouble() * (max - min) + min;
    //         arr[i] = Math.Round(num,1);
    //     }
    //     return arr;
    // }

    // void PrintArrayDouble(double[] arr)

    // {
    //     Console.Write("[");
    //     for (int i = 0; i < arr.Length; i++)
    //     {
    //         if (i < arr.Length - 1) Console.Write(arr[i] + ",");
    //         else Console.Write(arr[i]);
    //     }
    //     Console.WriteLine("]");
    // }