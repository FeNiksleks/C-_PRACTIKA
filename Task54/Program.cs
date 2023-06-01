// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt (int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
        
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
        Console.Write($"|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5}");
        }
         Console.WriteLine("| ");
     }
}

void SortElementovColumnsMatrixDecreasing (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
             if (matrix[i, k] < matrix[i, k + 1]) //для изменения сортировки поменять знак < на противоположный
                {
                    int temp = 0;
                    temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
             }
        }
    }
}


Console.WriteLine ("Введите количество строк");
int rrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов");
int ccolumns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите минимальное целое число диапазона");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное целое число диапазона");
int maximum = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(rrows, ccolumns, minimum, maximum);
PrintMatrix(array2d);
Console.WriteLine();
SortElementovColumnsMatrixDecreasing(array2d);
PrintMatrix(array2d);