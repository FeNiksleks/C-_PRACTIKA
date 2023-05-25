// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


bool SidesOfTheTriangle (int num1, int num2, int num3)
{
    // if (num1 + num2 > num3 && num2 + num3 > num1 && num1 + num3 > num2) return true;
    // return false;
    return num1 + num2 > num3 && num2 + num3 > num1 && num1 + num3 > num2;
    
}

Console.WriteLine("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int numC = Convert.ToInt32(Console.ReadLine());

bool Triangle = SidesOfTheTriangle (numA, numB, numC);
Console.WriteLine (Triangle ? "Труеголник может существовать" : "Труеголник не может существовать");

