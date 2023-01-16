// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8]; 
// array[0]=235;
// array[1]=33;
// array[2]=56;

// Console.WriteLine(array[]);

// for (int i=0; i<array.Length; i++)
// {
//     array[i]=2;
// }

// int[] array = new int [5]{2,5,7,9,0};
// int[] array = new int []{5,7};


int[] array = CreateArray(10, 9, 23);
PrintArray(array);

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(i < arr.Length - 1 ? arr[i] + ", " : arr[i] + "");
    }
    Console.Write("]");
}

