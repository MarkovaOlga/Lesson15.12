// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = 3;
int n = 2;

if (m < 0 || n < 0) Console.WriteLine("Введено отрицательное число или числа.");

else Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {FunctionAkerman(m, n)}");

int FunctionAkerman(int m1, int n1)
{
    if (m1 == 0)
        return n1 + 1;
    else if (n1 == 0)
        return FunctionAkerman(m1 - 1, 1);
    else
        return FunctionAkerman(m1 - 1, FunctionAkerman(m1, n1 - 1));
}