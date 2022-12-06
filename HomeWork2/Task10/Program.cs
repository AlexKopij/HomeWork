/*Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if ((number>=100) && (number<=999))
{
    int result = ((number / 100) * 10) + (number % 10);
    Console.WriteLine($"{result}");
}
else Console.WriteLine($"Вводимое число НЕ трёхзначное");
