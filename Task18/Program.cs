// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти координат");
Console.Write("Четверть №  ");
// int quarter = Convert.ToInt32(Console.ReadLine());
string quarter = Console.ReadLine();

string coordinate = Range (quarter);
string result = coordinate != null 
                ? $"Указанной четверти соответствуют следующие значения координат -> {coordinate}"
                : "Введена некорректная четверть";
Console.WriteLine(result);

// string Range (int q)
string Range (string q)
{
    if (q == "1") return "x > 0 && y > 0";
    if (q == "2") return "x < 0 && y > 0";
    if (q == "3") return "x < 0 && y < 0";
    if (q == "4" || q == "четыре") return "x > 0 && y < 0";
    // if (q == 1) return "x > 0 && y > 0";
    // if (q == 2) return "x < 0 && y > 0";
    // if (q == 3) return "x < 0 && y < 0";
    // if (q == 4) return "x > 0 && y < 0";
    return null;
}