/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
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

//Нахождение среднего арифметического элементов в каждом столбце
void GetNewMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1) ; i++)
    {
        double avr = 1;
        double sum = 0; 
        double l = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
          sum = sum + matrix[j,i]; 
        }
        avr = sum/Convert.ToDouble(matrix.GetLength(0));
        Console.WriteLine($"Среднее арифметическое столбца № {l=i+1} = " + "{0:0.#}", avr);
        
    }

}
    

int m = GetNumber("Введите количество строк: ");
int n = GetNumber("Введите количество столбцов: ");

int[,] matrix = GetMatrix(m, n);

Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
GetNewMatrix(matrix);
Console.WriteLine();

