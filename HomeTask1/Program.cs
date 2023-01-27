/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

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
double[,] GetMatrix(int m, int n)
{
   double [,] matrix = new double [m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = 20.0 * rnd.Next() / 2147483648 - 10.0;
        }
    }
    return matrix;
}

//Распечатать матрицу
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,5:f1}", matrix[i, j]));
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Введите количество строк: ");
int n = GetNumber("Введите количество столбцов: ");

double[,] matrix = GetMatrix(m, n);

PrintMatrix(matrix);