/* Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3 */


int[,] array = new int [3, 5];
double[] average = new double [array.GetLength(1)];

FillArray(array);
PrintArray(array);
CalculationAverage(array, average);
Console.WriteLine();
PrintAverage(average);

void CalculationAverage(int[,] InputArray, double[] Calculation)
{
    double rows = Convert.ToDouble(InputArray.GetLength(0));
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            Calculation[j] += InputArray[i, j] / rows;
        }
    }
}

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintAverage(double[] inputArray)
{
    int count = inputArray.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{Math.Round(inputArray[position], 1)}; ");
        position++;
    }
    Console.WriteLine();
}