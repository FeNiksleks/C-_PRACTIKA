// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] array = new int[8]; // 0, 1, 2, 3, 4, 5, 6, 7
// // array[7] = 45;
// // array[0] = 4;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i * 2;
//     Console.Write(array[i] + " ");
// }
// FillArray
// PrintArray
// CreateArray

// int array[i] = new Random().Next(0,2);

int[] array = new int[8];

FillArray(array);
Console.Write("[");
SeeArray(array);
Console.Write("]");
Console.WriteLine("\n");


void FillArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,2);

    }
}

void SeeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
{
    Console.Write(array[i] + " ");
    }
}
