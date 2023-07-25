// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// int rows = 4;
// int columns = 4;

// double[,] array2D = GetMatrixDouble(rows, columns);
// PrintMatrix(array2D);
// double[,] GetMatrixDouble(int m, int n)
// {
//     double[,] matrix = new double[m, n]; 
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {    
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Math.Round(new Random().NextDouble()* 10, 2);
//         }

//     }
//     return matrix;
// }

// void PrintMatrix (double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }

// }


// ==================
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.Write("Введите индекс элемента в строке: ");
// int rowIndex = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите индекс элемента в столбце: ");
// int columnIndex = Convert.ToInt32(Console.ReadLine());
// int rows = 4;
// int columns = 5;
// int minRandom = 2;
// int maxRandom = 50;


// int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);
// PrintMatrix(array2D);
// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; 
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {    
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max+ 1);
//         }

//     }
//     return matrix;
// }

// void PrintMatrix (int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }

// }
// if (rowIndex >= 0 && rowIndex < rows && columnIndex >= 0 && columnIndex < 4)
// {
//     int element = array2D[rowIndex, columnIndex];
//     Console.WriteLine($"Запрашиваемый элемент: {element}");
// }
// else
// {
//     Console.WriteLine("Такого элемента нет!");
// }

// =============================================
// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
 

// int minRandom = 0;
// int maxRandom = 10;

// int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);

// PrintMatrix(array2D);
// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; 
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {    
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max+ 1);
//         }

//     }
//     return matrix;
// }

// void PrintMatrix (int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }

// }

// for (int i = 0; i < array2D.GetLength(1); i++)
// {
//     double sumColums = 0;
//     for (int j = 0; j < array2D.GetLength(0); j++)
//     {
//         sumColums += array2D[j, i];
//     }
//     Console.WriteLine($"Среднее арифметическое столбца {i}= {Math.Round(sumColums / array2D.GetLength(0), 2 )}");

// }