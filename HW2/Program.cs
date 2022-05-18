/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int row = InputNumber("строки");
int colomn = InputNumber("столбца");

int[,] array = new int[5, 6];

FillArray(array);
PrintArray(array);
Console.WriteLine();

if(row-1 >= array.GetLength(0) || colomn-1 >= array.GetLength(1) || row <= 0 || colomn <= 0)
{
    Console.Write($"Эллемент массива под значениями {row}-{colomn} отсутствует"); 
}
else
{
    Console.Write($"Элемент массива под значениями {row}-{colomn} равен {array [row-1, colomn-1]}");
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

