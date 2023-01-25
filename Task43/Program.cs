// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение для b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение для k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение для b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение для k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double resultx = ValueOfX(b1, k1, b2, k2);
resultx = Math.Round(resultx, 2);
double resulty = ValueOfY(resultx, b2, k2);
resulty = Math.Round(resulty, 2);

Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({resultx}; {resulty})");

double ValueOfX(double bb1, double kk1, double bb2, double kk2)
{
    double xx = (bb2 - bb1) / (kk1 - kk2);
    return xx;
}
double ValueOfY(double x1, double bb2, double kk2)
{
    double yy = kk2 * x1 + bb2;
    return yy;
}