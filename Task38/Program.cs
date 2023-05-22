
double[] CreateArrayRndInt (int size, int min, int max)
{
    double[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);

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

// double[] CreateArrayRndDouble(int size, int min, int max)
// {
//     double[] arr = new double[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         double num = rnd.NextDouble() * (max - min) + min;
//         arr[i] = Math.Round(num, 1);
//     }
//     return arr;
// }
// void PrintArrayDouble(double[] arr, string sep)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
//         else Console.Write($"{arr[i]}");
//     }
// }