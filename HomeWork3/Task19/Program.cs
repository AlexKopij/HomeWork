/*Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());


if ((number > 9999) && (number < 100000))
{
    string num = number.ToString();
    if (((num[0] == num[4])) && (num[1] == num[3]))
    {
        Console.WriteLine("Число является палиндромом");
    } 
    else Console.WriteLine("Данное число не является полиндромом");
}
else Console.WriteLine("Данное число НЕ пятизначное");


