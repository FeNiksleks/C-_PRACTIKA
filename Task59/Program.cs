// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7
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

int[] MinElemIndexes (int[,] matrix)
{
    int min = matrix[0,0];
    int indexRows = 0;
    int indexColumns = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if (matrix[i,j] < min) //это первый минимальный элемент чтобы был последний нужно изменить условие на <=
           {
            min = matrix[i,j];
            indexRows = i;
            indexColumns = j;
           }
        }
        
    }
    return new int[] {indexRows, indexColumns, min};
    
}

int[,] DeleteRowsColumnsMinElement (int[,] matrix, int indexRows, int indexColumns)
{
    int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    int m = 0;
    int n = 0;       
    for (int i = 0; i < newMatrix.GetLength(0); i++) // rows = arr.GetLength (0)
    {       
        if (m == indexRows) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++) // columns = arr.GetLength (1)
        {
            if (n == indexColumns) n++;
            newMatrix[i,j]= matrix[m,n];
            n++;
        }
        m++;
        n=0;
    }
    return newMatrix;
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
Console.WriteLine(); //разделяем новый и старый массив пустой строкой
int[] minElemIndexes = MinElemIndexes(array2d);
Console.WriteLine(minElemIndexes[2]);
Console.WriteLine();
int[,] newArray2d = DeleteRowsColumnsMinElement(array2d, minElemIndexes[0], minElemIndexes[1]);
PrintMatrix(newArray2d);
