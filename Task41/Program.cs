// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = EnterNumbers(num);
PrintArray(array);
int result = PositiveNumbers(array);
Console.WriteLine($"-> {result}");

int[] EnterNumbers(int m)
{
    int[] arr = new int[m];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число из {m}: ");
        int number = Convert.ToInt32(Console.ReadLine());
        arr[i] = number;
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
}

int PositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}