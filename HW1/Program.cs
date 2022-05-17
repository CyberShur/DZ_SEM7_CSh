﻿/* Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9  */


int m = InputNumber("m");
int n = InputNumber("n");

double[,] array = new double [m, n];

FillArray(array);
PrintArray(array);

void FillArray(double[,] collection)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            collection[i, j] = new Random().Next(-100, 100) + new Random().NextDouble();
            Math.Round(collection[i, j], 1);
        }
    }
}

void PrintArray(double[,] inputArray)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(Math.Round(inputArray[i, j], 1) + " ");
        }
        Console.WriteLine();
    }
}

int InputNumber(string number)
{
    Console.Write($"Введите число {number}: "); 
    return Convert.ToInt32(Console.ReadLine());
}