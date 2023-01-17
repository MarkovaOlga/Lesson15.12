// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число: ");
int b = Convert.ToInt32(Console.ReadLine());
Degree(a, b);

void Degree(int a1, int b1)
{
    if (b1 > 0) Console.WriteLine($"{Math.Pow(a1, b1)}");
    else Console.WriteLine("Вы ввели ненатуральное число");
}