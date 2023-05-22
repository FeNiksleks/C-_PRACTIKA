// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max, int roun )
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, roun);
    }
    return arr;
}
void PrintArrayDouble(double[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

double MinNumberArrayDouble (double[] arr)
{
    double minArr = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < minArr) minArr = arr[i];
    }
    return minArr;
}

double MaxNumberArrayDouble (double[] arr)
{
    double maxArr = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > maxArr) maxArr = arr[i];
    }
    return maxArr;
}

double DifferenceNumberArrayDouble (double min, double max, int roun)
{
    double diff = max - min;
    double diffRound = Math.Round(diff, roun);
    return diffRound;
}
Console.WriteLine("Введите число знаков после запятой: ");
int roun = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArrayRndDouble(10, 0, 100, roun);
Console.Write("[");
PrintArrayDouble(array, " ,");
Console.WriteLine("]");
double maxNumArray = MaxNumberArrayDouble(array);
Console.WriteLine($"Максимальный элемент массива = {maxNumArray}");
double minNumArray = MinNumberArrayDouble(array);
Console.WriteLine($"Минимальный элемент массива = {minNumArray}");
double difference = DifferenceNumberArrayDouble(minNumArray, maxNumArray, roun);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {difference}");
Console.Write("Итог: ");
Console.Write("[");
PrintArrayDouble(array, " ,");
Console.Write($"] -> {difference} ");




