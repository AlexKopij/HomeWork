/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

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
int GetExponentiation (int num1, int num2)
{
   int exp = 1;
   for (int i = 1; i <= num2; i++)
        exp = exp * num1;
    return exp;
}
int num1 = GetNumber("Введите число первое число: ");
int num2 = GetNumber("Введите число второе число: ");
int exp = GetExponentiation(num1, num2);

Console.Write($"Число {num1} в степени {num2} равно {exp}");