/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
Console.WriteLine("Введите число 1");
string input0 = Console.ReadLine();
Console.WriteLine("Введите число 2");
string input1 = Console.ReadLine();
Console.WriteLine("Введите число 3");
string input2 = Console.ReadLine();
int num1 = Convert.ToInt32(input0);
int num2 = Convert.ToInt32(input1);
int num3 = Convert.ToInt32(input2);
int max = num1;

if (max < num2)
{
    max = num2;
}
if (max < num3)
{
    max = num3;    
}

Console.WriteLine($"Большее число {max}");