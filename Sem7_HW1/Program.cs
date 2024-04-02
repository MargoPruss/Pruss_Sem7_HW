// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void PrintNaturalNumbers(int M, int N)
{
   if(M > N)
    {
    Console.Write($"{M} ");
    PrintNaturalNumbers(M - 1, N);
    }
    if(M < N)
    {
    PrintNaturalNumbers(M, N - 1);
    Console.Write($"{N} ");
    }
}

Console.WriteLine("Введите первое натуральное число: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M < N) Console.Write(M + " ");
PrintNaturalNumbers(M, N);
if (M > N) Console.Write(N);