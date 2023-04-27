// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

Square(number, degree);
void Square (int num, int pow)
{
        int count = 1;
    while (count <= num)
{
    
        Console.WriteLine($"{count,3}  {Math.Pow(count, pow),5}");
            
    count++;
}
}