/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/
Console.WriteLine("Введите число");
string input0 = Console.ReadLine();
int num0 = Convert.ToInt32(input0);

if (num0 % 2 == 0)
{
    Console.WriteLine($"Число {num0} является четным");
}
else Console.WriteLine($"Число {num0} является НЕчётным");