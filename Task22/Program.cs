// Напишите программу, которая принимает на вход число (N) и 
// выдает таблицу квадратов чисел от 1 до N
// 5 ->
// 1 1
// 2 4
// 3 9
// 4 16
// 5 25 

Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    Squars(n);
}
else Console.WriteLine("Вы ввели не натуральное число");
void Squars(int n1)
{
    int count = 1;
    while (count <= n1)
    {
        Console.WriteLine($"{count}\t" + Math.Pow(count, 2));
        count++;
    }
}