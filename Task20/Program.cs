// Нашишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве
// A (3,6);B(2,1) -> 5,09
// A (7,-5);B(1,-1)->7,21

Console.WriteLine("Введите координаты двух точек: ");
Console.Write("XA: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("YA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("YB: ");
int yb = Convert.ToInt32(Console.ReadLine());

double ourDistance = Math.Round(Distance(xa, ya, xb, yb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками {xa}, {ya}  и {xb}, {yb} -> {ourDistance}");

double Distance(int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2));
    return distance;
}