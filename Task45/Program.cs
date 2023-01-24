// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] array = CreateArrayRndInt(9, 10, 100);
PrintArray(array);
int[] newarray = CopyOfArrayRndInt(array);
//newarray[0] = 30;
PrintArray(newarray);

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
        if (i < arr.Length - 1) Console.Write(arr[i] + " ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}


int[] CopyOfArrayRndInt(int[] copyarr)
{
    int[] copyarr1 = new int[copyarr.Length];
    for (int i = 0; i < copyarr1.Length; i++)
    {
        copyarr1[i] = array[i];
    }
    return copyarr1;
}


// string str ="1,4,6,8,0,-56";
// string[] strArr = str.Split(',');