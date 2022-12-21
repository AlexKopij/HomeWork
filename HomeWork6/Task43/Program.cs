/*Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("Введите значение b1");
string num1 = Console.ReadLine();
Console.WriteLine("Введите значение k1");
string num2 = Console.ReadLine();
Console.WriteLine("Введите значение b2");
string num3 = Console.ReadLine();
Console.WriteLine("Введите значение k2");
string num4 = Console.ReadLine();

double b1 = Convert.ToDouble(num1);
double k1 = Convert.ToDouble(num2);
double b2 = Convert.ToDouble(num3);
double k2 = Convert.ToDouble(num4);

double x = (b1 - b2) / (k2 - k1);
double y = k2 * x + b2;

Console.WriteLine($"Координаты точки пересечения прямых: ({x}; {y})");