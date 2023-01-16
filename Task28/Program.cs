// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int mult = Fact(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {mult}");

int Fact(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
        mult = mult * i; //mult *=i
        }
    }
    return mult;
}