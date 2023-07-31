// =====================================================
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] result = GetMatrix3D(2,2,2, 0, 10);
// int[,,] GetMatrix3D(int m, int n, int h, int min, int max)
// {
//     int[,,] matrix = new int[m, n, h];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         // i, k, m, n, j
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            for (int k = 0; k < matrix.GetLength(2); k++)
//            {
//                 matrix[i, j, k] = new Random().Next(min, max + 1);
//            }
//         }
//     }
//     return matrix;
// }


// void PrintMatrix3D(int[,,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         // i, k, m, n, j
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 Console.Write($"{matrix[i, j, k]}({i},{j},{k})  ");
//             }
//             Console.WriteLine();
//         }
       
//     }
// }    
// PrintMatrix3D(result);



// ==========================
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] firstMatrix = GetMatrix(2,2, 0, 10);
// int[,] secondMatrix = GetMatrix(2,2, 0, 10);
// Console.WriteLine("Первый массив: ");
// PrintMatrix(firstMatrix);
// Console.WriteLine("Второй массив: ");
// PrintMatrix(secondMatrix);
// Console.WriteLine("Массив с перемноженными элементами:");
// PrintMatrix(MultiplicationMatrix(firstMatrix, secondMatrix, 2, 2));

// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; 
//     for (int i = 0; i < matrix.GetLength(0); i++) 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }    


// int[,] MultiplicationMatrix(int[,] firstMatr, int[,] secondMatr, int m, int n)
// {
//     int[,] matr = new int[m, n]; 
//     for (int i = 0; i < matr.GetLength(0); i++) 
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = firstMatr[i, j] * secondMatr[i, j];
//         }    
//     }
//     return matr;
// }


// ================================================================
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Исходный массив: ");
// int[,] array2D = GetMatrix(3,3, 0, 25);
// PrintMatrix(array2D);
// Console.WriteLine("Массив с упорядоченными элементами: ");
// SortMatrix(array2D);
// PrintMatrix(array2D);

// void SortMatrix(int[,] matrix)
// {
//     int temp = 0;   
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 if (matrix[i, k] < matrix[i, k + 1])
//                 {
//                     temp = matrix[i, k + 1];
//                     matrix[i, k + 1] = matrix[i, k];
//                     matrix[i, k] = temp;
//                 }        
//             }
//         }
//     }
// }


// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; 
//     for (int i = 0; i < matrix.GetLength(0); i++) 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) 
//     {
        
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t"); 
//         }
//         Console.WriteLine();

//     }
// }    





// // =================================================
// // Задача 56: Задайте прямоугольный двумерный массив. 
// // Напишите программу, которая будет находить строку с
// //  наименьшей суммой элементов.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой 
// // строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// !!!!!!!! задача не решена, считает не корректно!!!!!!!
// int[,] baseMatrix = GetMatrix(3,4, 0, 5);
// Console.WriteLine($"В массиве: ");
// PrintMatrix(baseMatrix);
// int row = SumRowMatrix(baseMatrix);
// Console.WriteLine($"Минимальная сумма элементов в строке {row}");


// int SumRowMatrix(int[,] matr)
// {
//     int[] sumRow = new int[matr.GetLength(0)];
    
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             sumRow[i] = sumRow[i] + matr[i,j];
//         }
//     }
//     int minSumRow = sumRow[0];
//     int minRow = 1; 
//     for (int i = 1; i < matr.GetLength(0); i++)
//     {
//         if(sumRow[i] < minSumRow)
//         {
//             minSumRow = sumRow[i];
//             minRow = i++;
//         }
//     }
//     return minRow;
// }


// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; 
//     for (int i = 0; i < matrix.GetLength(0); i++) 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t"); 
//         }
//         Console.WriteLine();
//     }
// }    


