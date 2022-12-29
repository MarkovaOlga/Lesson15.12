// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    Cube(n);
}
else Console.WriteLine("Вы ввели не натуральное число");
void Cube(int n1)
{
    int count = 1;
    while (count <= n1)
    {
        Console.WriteLine($"{count,7} {Math.Pow(count, 3), 7}");
        count++;
    }
}