﻿/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] arr = new int[8];
Random num = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = num.Next(0, 99); 
}
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}