// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите день недели");
// int number = Convert.ToInt32(Console.ReadLine());
int number;
do {
    Console.WriteLine("Введите день недели ");
    Int32.TryParse(Console.ReadLine(), out number);
} while(number > 7);
// Console.WriteLine("Это не день недели");
// if (number > 7)
// {
//     Console.WriteLine("Это не день недели");
//     restart programm
// }
if (number <= 5)
{
    Console.WriteLine($"{number} -> нет ");
}
else
{
    Console.WriteLine($"{number} -> да ");
}



// int digit;
// do {
//     Console.WriteLine("Введите возраст: ");
//     Int32.TryParse(Console.ReadLine(), out digit);
// } while(digit < 14 || digit > 85);
// Console.WriteLine(digit);