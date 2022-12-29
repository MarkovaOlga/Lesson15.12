// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number5 = Convert.ToInt32(Console.ReadLine());
if (number5 > 99999 || number5 < 10000) Console.WriteLine("Вы ввели не пятизначное число");
else Console.WriteLine(Polindrome(number5) ? "Да" : "Нет");

bool Polindrome(int num5)
{
    int num1 = num5 % 10;
    int num2 = num5 / 10000;
    int num3 = num5 / 10 % 10;
    int num4 = num5 / 1000 % 10;

    return num1 == num2 && num3 == num4;
}