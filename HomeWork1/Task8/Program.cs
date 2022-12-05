/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/
Console.WriteLine("Введите число");
string input0 = Console.ReadLine();
int num1 = Convert.ToInt32(input0);

if (num1 >= 1)
{
  for (int i = 1; i <= num1; i++)
    {if (i % 2 == 0)
        {
        Console.Write(i + ", ");
        }
    }
}
else Console.WriteLine("Вводимое число должно быть больше 1");

