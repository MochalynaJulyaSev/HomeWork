﻿
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int start, int end) 
// {
//     if (start == end) return start.ToString(); 
//     return start + ", " + PrintNumbers(start - 1, end);
// }

// Console.WriteLine($"Числа от {n} до 1: {PrintNumbers(n, 1)}");



// ====================================================================
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int PrintSumNumbers(int start, int end) // start = 1, end = n
// {
//     if (start == end) return start;  
//     return start + PrintSumNumbers(start + 1, end);
// }

// Console.WriteLine($"Сумма натуральных чисел от {m} до {n}: {PrintSumNumbers(m, n)}");


// ========================================================================
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int AkkermanFunktion(int m, int n)
// {
// if (m == 0) return n + 1;
// if (n == 0) return AkkermanFunktion(m - 1, 1);
// return AkkermanFunktion(m - 1, AkkermanFunktion(m, n - 1));
// }

// Console.Write($"А({m},{n}) = {AkkermanFunktion(m, n)} ");