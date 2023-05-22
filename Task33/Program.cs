// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
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

bool SelectionmSort (int[] arr, int target)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == target) return true;
    }
        return false;
        
}


int[] array = CreateArrayRndInt(12, -9, 9);
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");
bool Select = SelectionmSort (array, number);
Console.WriteLine (Select ? "Число есть" : "Числа нет");