/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
Console.WriteLine("Введите число 1");
string input0 = Console.ReadLine();
Console.WriteLine("Введите число 2");
string input1 = Console.ReadLine();
int num1 = Convert.ToInt32(input0);
int num2 = Convert.ToInt32(input1);

if (num1 < num2) 
{
    Console.Write($"Большее число {num2} меньшее число {num1}");

}else
{
    Console.Write($"Большее число {num1} меньшее число {num2}");
}

