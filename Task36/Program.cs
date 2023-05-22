// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr, string sep )
{
     for (int i = 0; i < arr.Length; i++)
     {
    if(i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
    else Console.Write($"{arr[i]}");

     }
}

int SumOddNumberArray (int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if(i % 2 == 1) sum +=arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(10, -2, 4);
Console.Write("[");
PrintArray(array, ",");
Console.Write("] -> ");
int sum = SumOddNumberArray(array);
Console.Write(sum);
