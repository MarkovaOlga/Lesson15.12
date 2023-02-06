// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

int m = secondnumber, n = firstnumber;
if (firstnumber > secondnumber)
{
    m = firstnumber;
    n = secondnumber;
}
if (n < 0) n = 0;
if (n < 0 || m < 0) Console.WriteLine("Вы ввели числа меньше нуля. Хотя бы одно число должно быть больше 0");
else Console.WriteLine(SumOfNumbers(m, n));

int SumOfNumbers(int m1, int n1)
{
    if (m1 == n1) return m1;
    else return m1 + SumOfNumbers(m1 - 1, n1);
}