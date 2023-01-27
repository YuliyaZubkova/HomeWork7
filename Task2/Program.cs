﻿/* Задача 46: Задайте двумерный массив размером m×n,
 каждый элемент в массиве находится по формуле
 А = m + n. Выведите полученный массив на экран.

 m = 3, n = 4.
 0 1 2 3
 1 2 3 4
 2 3 4 5

1. Получить числа с консоли
2. Задать матрицу и заполнить ее числами с консоли
3. Распечатать матрицу

*/


// Получить числа с консоли
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено не число.");

        }
    }

    return result;
}

//Задать матрицу и заполнить ее числами с консоли
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
  
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

//Распечатать матрицу
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Введите количество строк: ");
int n = GetNumber("Введите количество столбцов: ");

int[,] matrix = GetMatrix(m, n);

PrintMatrix(matrix);