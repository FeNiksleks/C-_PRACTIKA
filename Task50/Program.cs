// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

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

bool PositionMatrix (int[,] matrix, int rows, int columns)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if(i  == rows - 1 && j == columns - 1 ) return true; //Добавил уменьшение на 1 из-за того что пользователь не знает что счет элементов массива начинается с 0, а не с 1.
        }
        
    }
    return false;
}
Console.WriteLine("Введите позицию элемента в двумерном массиве: ");
Console.Write("Введите строку: ");
int numRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int numColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);
bool Position = PositionMatrix (array2d, numRows, numColumns);
Console.Write($"{numRows},{numColumns} -> ");
Console.WriteLine (Position ? "такой элемент есть в массиве" : "такого элемента в массиве нет");

