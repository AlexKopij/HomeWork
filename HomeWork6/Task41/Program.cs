/*Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите числа через пробел");
string str = Console.ReadLine();
int[] arr = Array.ConvertAll(str.Split(' '), int.Parse);
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
        sum = sum + 1;
}
Console.WriteLine($"Количество чисел которые больше нуля составляет: {sum}");
