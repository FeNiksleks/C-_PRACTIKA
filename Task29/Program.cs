// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите количество элементов массива: ");
int inter = Convert.ToInt32(Console.ReadLine());
 int[] Arr = CreateArray(inter);
Console.Write("[");
PrintArray(Arr);
Console.Write("]");

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
{
    if(i < array.Length - 1) Console.Write($"{array[i]}, ");
    else Console.Write($"{array[i]}");
}

 }

int[] CreateArray(int size)
{
int[] array = new int[size];
var rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rnd.Next(0, 100);
}
return array;
 }


//  //int[] arr = new int[8];

//            // FillArray(arr);
//             int[] newArr = CreateArray(12);
//             Console.Write("[");
//             PrintArray(newArr);
//             Console.Write("]");

//             void PrintArray(int[] array)
//             {
//                 for (int i = 0; i < array.Length; i++)
//                 {
//                     if(i < array.Length - 1) Console.Write($"{array[i]}, ");
//                     else Console.Write($"{array[i]}");
//                 }

//             }

//             void FillArray(int[] array)
//             {
//                 var rnd = new Random();
//                 for (int i = 0; i < array.Length; i++)
//                 {
//                     array[i] = rnd.Next(0, 2);
//                 }
//             }