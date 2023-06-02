// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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
int[,] MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix)
{
    int[,] resultMatrix = new int[firstMartrix.GetLength(0),secomdMartrix.GetLength(1)];

  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
  return resultMatrix;
}

Console.WriteLine ("Введите количество строк матрицы №1");
int rrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов матрицы №1");
int ccolumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество строк матрицы №2");
int rrows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов матрицы №2");
int ccolumns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите минимальное целое число диапазона");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное целое число диапазона");
int maximum = Convert.ToInt32(Console.ReadLine());

int[,] firstArray2d = CreateMatrixRndInt (rrows, ccolumns, minimum, maximum);
PrintMatrix(firstArray2d);
Console.WriteLine(); //разделяем новый и старый массив пустой строкой
int[,] secomdArray2d = CreateMatrixRndInt (rrows2, ccolumns2, minimum, maximum);
PrintMatrix(secomdArray2d);
Console.WriteLine(); //разделяем новый и старый массив пустой строкой
if (rrows2 != ccolumns) 
{
    Console.WriteLine ("Замена строк столбцами невозможна");
    return;
} 
Console.WriteLine(); //разделяем новый и старый массив пустой строкой
int[,] resultMatrix =  MultiplyMatrix(firstArray2d, secomdArray2d);
PrintMatrix(resultMatrix);

