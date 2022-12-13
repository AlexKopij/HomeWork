/*Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;
  
    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0) 
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Введено недопустимое значение");
        }
    }

    return result;
}
int GetSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int num1  = number %10;
        number /= 10;
        sum += num1;
    }
    return sum;
}
int number = GetNumber("Введите число");
int sum = GetSum(number);

Console.Write($"Сумма цифр числа {number} равна: {sum}");