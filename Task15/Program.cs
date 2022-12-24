// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 0 || day > 7)
    Console.WriteLine("Такого дня недели нет");
else Console.WriteLine(DayOfWeek(day) ? "Выходной" : "Не выходной");

bool DayOfWeek(int dayweek)
{
    return dayweek == 6 || dayweek == 7;
}