Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max;

if (number1 > number2) max = number1;
else max = number2;

Console.WriteLine($"{max} больше");