﻿// Задача 2: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// Пример
// m = 2, n = 3 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write("Введите положительное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{Akkerman(m, n)}");