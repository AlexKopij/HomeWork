/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100)
{
    string num = number.ToString();
    Console.WriteLine($"Третья цифра данного числа {num[2]}");
}
else Console.WriteLine("Вводимое число не имеет третьей цифры");
