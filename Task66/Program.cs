// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M;                       
    else if (M < N) return N + SumNumbers(M, N - 1); 
    else return N + SumNumbers(M, N + 1);            
}

Console.WriteLine("Введите значение начала промежутка M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите  значение окончания промежутка N:");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0) Console.Write("Одно из введенных чисел не натуральное. Проверьте вводимые данные.");
if (numberM < 0 || numberN < 0) return;

int sum= SumNumbers(numberN, numberM);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");