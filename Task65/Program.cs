// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите первое натуральное число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

NaturalNumbersRange(firstnumber, secondnumber);

void NaturalNumbersRange(int firstnum, int secondnum)
{
    if (firstnum == secondnum) Console.WriteLine($"{firstnum} ");
    if (firstnum < secondnum)
    {
        Console.Write($"{firstnum} ");
        NaturalNumbersRange(firstnum + 1, secondnum);
    }
    if (firstnum > secondnum)
    {
        Console.Write($"{firstnum} ");
        NaturalNumbersRange(firstnum - 1, secondnum);
    }
}
