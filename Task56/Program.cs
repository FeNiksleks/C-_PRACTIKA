// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt (int size, int min, int max)
{
    int[,] matrix = new int[size, size];
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


int MinSumElemenMatrix (int[,]matrix)
        {
            int minI = 0;
            int[] sumElemenColumns = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sumElemenColumns[i] += matrix[i, j];
                }

            }
            
            for (int i = 0; i < sumElemenColumns.Length; i++)
            {
                if (sumElemenColumns[minI] > sumElemenColumns[i]) minI = i;
            }
            return minI;
        }

Console.WriteLine ("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());


Console.WriteLine ("Введите минимальное целое число диапазона");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное целое число диапазона");
int maximum = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(size, minimum, maximum);
PrintMatrix(array2d);
Console.WriteLine(); //разделяем новый и старый массив пустой строкой
int minSumElemenMatrix = MinSumElemenMatrix(array2d);
Console.WriteLine();

Console.WriteLine($"Номер строки с наименьшей суммой элементов -> {minSumElemenMatrix + 1}");


