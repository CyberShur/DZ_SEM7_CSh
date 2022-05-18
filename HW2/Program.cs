/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */


int m = InputNumber("строки");
int n = InputNumber("столбца");

int[,] array = new int[5, 6];

FillArray(array);
PrintArray(array);
Console.WriteLine();

if(m-1 >= array.GetLength(0) || n-1 >= array.GetLength(1))
{
    Console.Write($"Эллемент массива под значениями {m}-{n} отсутствует"); 
}

for(int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if(m-1 == i && n-1 == j)
        {
            Console.Write($"Эллемент массива под значениями {m}-{n} равен {array[i, j]}");
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

int InputNumber(string number)
{
    Console.Write($"Введите номер {number}: "); 
    return Convert.ToInt32(Console.ReadLine());
}

