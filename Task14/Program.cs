// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(BothMultiple(number, 5, 10) ? "Да" : "Нет");

bool BothMultiple(int num, int num1 = 7, int num2 = 23)
{
    return num % num1 == 0 && num % num2 == 0;
}