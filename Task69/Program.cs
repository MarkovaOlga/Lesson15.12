// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int numdegree = Convert.ToInt32(Console.ReadLine());

if (numdegree > 0)
{
    Console.WriteLine(MathPow(number, numdegree));
}
else Console.WriteLine("Ошибка ввода степени");

int MathPow(int num, int degree)
{
    if (degree == 0) return 1;
    else return num * MathPow(num, degree - 1);
}