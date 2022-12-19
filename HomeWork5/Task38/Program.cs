/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

//получить размерность массива с консоли
int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;  
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите корректное число");
        }
    }
    return result;
}
//получить заполненный массив вещественными числами
double[] InitArray(int dimension)
{
    double[] array = new double[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (100-1), 2);
    }

    return array;
}
//распечатать массив на консоль
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

double GetDiff(double[] array)
{
    double max = array[0];
    double min = array[0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        } 
        if (array[i] < min)
        {
            min = array[i];
        }         
    }
    diff = Math.Round((max - min), 2);
    return diff;
}
int dimension = GetNumber("Введите размерность массива: ");
double[] array = InitArray(dimension);
PrintArray(array);
double diff = GetDiff(array);
Console.Write($"Разница между максимальным и минимальным элементами заданного массива составляет: {diff}");