/*Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите цифру обозначающую день недели");
string number = Console.ReadLine();
int day = Convert.ToInt32(number);

if (day < 8)
{
    if (day > 5)
    {
        Console.WriteLine("Это выходной день");
    }
    else Console.WriteLine("Это будний день");
}
else Console.WriteLine("Вводимое число не соответствует номеру дня недели");