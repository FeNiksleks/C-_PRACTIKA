// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(double x1, double y1, double z1, double x2, double y2, double z2, int pow)
{
    double sumCatet = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2);
    double dist = Math.Sqrt(sumCatet);
    double round = Math.Round(dist, pow, MidpointRounding.ToZero);
    return round;
}

Console.WriteLine("Введите координаты точки А");
Console.Write("X1: ");
double x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
double y1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
double z1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки В");
Console.Write("X2: ");
double x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
double y2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
double z2Coordinate = Convert.ToInt32(Console.ReadLine());
// Можно убрать запрос и вводить количество знаков после запятой непосредственно при обращении к функции "Distance"
Console.Write("Введите количество выводимых знаков после запятой : ");
int rounding = Convert.ToInt32(Console.ReadLine());
//Вместо переменной "rounding" можно указать конкретное число при обращении к функции "Distance"
double distance = Distance (x1Coordinate, y1Coordinate, z1Coordinate, x2Coordinate, y2Coordinate, z2Coordinate, rounding); 

Console.WriteLine ($"A({x1Coordinate},{y1Coordinate},{z1Coordinate}); B({x2Coordinate},{y2Coordinate},{z2Coordinate}) -> {distance}" );

