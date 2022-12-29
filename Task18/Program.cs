// Напишите программу, которая по заданному номеру четверти, 
// показывает диапозон возможных коордигнат точек в этой четверти (x и y)

Console.WriteLine("Введите номер четверти");
string number=Console.ReadLine();

string result = Quarter(number);
Console.WriteLine(result);
string Quarter(string numb)
{
    if (number == "1") return "x > 0; y > 0";
    if (number == "2") return "x < 0; y > 0";
    if (number == "3") return "x < 0; y < 0";
    if (number == "4") return "x > 0; y < 0";
    return "Нет такого номера четверти";
}