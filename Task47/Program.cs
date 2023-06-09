﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


double[,] CreateMatrixRndInt (int rows, int columns, int min, int max, int roun)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(num, roun);

        }
        
    }
    return matrix;
}

void PrintMatrix (double[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
        Console.Write($"|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 7}");
        }
         Console.WriteLine("| ");
     }
}
Console.WriteLine("Введите число знаков после запятой: ");
int roun = Convert.ToInt32(Console.ReadLine());
double[,] array2d = CreateMatrixRndInt(3, 4, -10, 10, roun);
PrintMatrix(array2d);