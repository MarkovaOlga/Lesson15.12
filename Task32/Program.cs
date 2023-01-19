// 32.Напишите программу замена элементов массива: 
// положительные элементы 
// замените на соответствующие отрицательные и наоборот
// [-4,-8,8,2]->[4,8,-8,-2]

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
void ChangeNumbers(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        // if (arr[i] > 0) arr[i] = -arr[i];
        // else if (arr[i] < 0) arr[i] = arr[i] * -1;
        arr[i] *=-1;
    }
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
int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
//int[] newArray = ChangeNumbers(array);
ChangeNumbers(array);
PrintArray(array);