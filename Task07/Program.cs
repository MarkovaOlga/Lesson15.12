Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >=100 && number <1000)
Console.WriteLine($"Последняя цифра числа {number} равна {number % 10}");
else Console.WriteLine("Вы ввели не трехзначное число");