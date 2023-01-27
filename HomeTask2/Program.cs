/* Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
*/

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

int k = GetNumber("Введите позицию элемента по горизонтали в двухмерном массиве (число от 1 до 5): ");
int l = GetNumber("Введите позицию элемента по вертикали в двухмерном массиве (число от 1 до 5): ");
Console.WriteLine();
int[,] matrix = GetMatrix(k, l);


int[,] GetMatrix(int m, int n)
{
    m = 5; n = 5;
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

void GetNewMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == l - 1 && j == k - 1)
            {
                Console.WriteLine($"Значение элемента с позицией [{k}, {l}] = {matrix[i, j]}");
            }
        }

    }


}

PrintMatrix(matrix);
Console.WriteLine();
GetNewMatrix(matrix);
if (l <= 0 || k <= 0 || l > matrix.GetLength(0) || k > matrix.GetLength(1))
{
    Console.WriteLine($"Элемента с указанной позицией [{k}, {l}] в массиве нет.");
}
Console.WriteLine();


