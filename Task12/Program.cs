// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int 
    second = Convert.ToInt32(Console.ReadLine()),
    result = first % second;
if (result == 0)
    Console.WriteLine($"Число {first} кратно {second}");
else Console.WriteLine($"Число {first} не кратно {second}, остаток равен {result}");

// второй вариант

// int result = Div(first, second);
// Console.WriteLine(result == 0 ? "Кратно" : $"Не кратно, остаток от деления {result}");
// int Div(int first, int second)
// {
//     return first % second;
// }