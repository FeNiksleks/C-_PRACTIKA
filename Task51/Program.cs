// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// int[,] CreateMatrixRndInt (int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
        
//     }
//     return matrix;
// }

// void PrintMatrix (int[,] matrix)
// {
//      for (int i = 0; i < matrix.GetLength(0); i++)
//      {
//         Console.Write($"|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j], 5}");
//         }
//          Console.WriteLine("| ");
//      }
// }

// int SummMatrix(int [,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j ) sum +=matrix[i,j];
//         }
//     }
//     return sum;
// }


// int SumElem(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
//     {        
//     sum += matrix[i, i]; 
     
//     }

//     return sum;

// }

// int[] SumMatr(int[,] matrix)
// {
//     int sum = 0;
//     int size = matrix.GetLength(0) > matrix.GetLength(1) ? matrix.GetLength(1) : matrix.GetLength(0);
//     int [] newarray = new int [size];
//     for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
//     {        
//         newarray [i] = matrix[i,i];   
//     }

//     return newarray;
    
// }

// void PrintArray (int[] arr, string sep = ",")
// {
//      for (int i = 0; i < arr.Length; i++)
//      {
//     if(i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
//     else Console.Write($"{arr[i]}");
//     // Console.Write()
//     // arr[i] = rnd.Next(min, max + 1)
//      }
// }
// // int[,] array2d = CreateMatrixRndInt(3, 4, 1, 5);
// // PrintMatrix(array2d);
// // Console.WriteLine();
// // int summa = SummMatrix(array2d);
// // Console.Write(summa);

// int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
// PrintMatrix(array2d);
// int sumElem = SumElem(array2d);
// Console.WriteLine();
// Console.WriteLine($"Сумма элементов главной диагонали = {sumElem}");
// int[] arr = SumMatr[array2d];
// PrintArray(arr);



int[,] CreateMatrixFormula(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // rows = arr.GetLength (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns = arr.GetLength (1)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //Console.Write ($"| {i}"); //номер строки i
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} "); // 5 - форматирование отступа
        }
        //Console.Write ("|");
        Console.WriteLine();
    }
}

int SumElementsOnDiagonal(int[,] matr)
{
    int sum = 0;
    //int size = matr.GetLength(0) > matr.GetLength(1) ? matr.GetLength(1) : matr.GetLength(0);
    
    for (int i = 0; i < matr.GetLength(0) && i < matr.GetLength(1); i ++)
    {
        sum += matr[i, i];
    }
    return sum;
}


Console.WriteLine("Введите число строк");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число в массиве");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве");
int maximum = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixFormula(rows2, columns2, minimum, maximum); //лучше пользовательский ввод
PrintMatrix(array2d);
int sumElementsOnDiagonal = SumElementsOnDiagonal(array2d);
Console.WriteLine($"Сумма элементов главной диагонали равна {sumElementsOnDiagonal}");

