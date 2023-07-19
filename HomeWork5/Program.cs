// ============Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// int[] GetArray(int size, int min, int max)
// {
//     int[] result = new int[size]; 
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min,max + 1);
//     }
//     return result; 
// }    

// int[] array = GetArray(7,100,200); 
// Console.WriteLine($"Массив: {string.Join("; ", array)}");
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] % 2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"В массиве {count} чётных числа ");


// ========Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int[] GetArray(int size, int min, int max)
// {
//     int[] result = new int[size]; 
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min,max + 1);
//     }
//     return result; 
// }    

// int[] array = GetArray(6,-9,10); 
// Console.WriteLine($"Массив: {string.Join("; ", array)}");
// int sum =0;
// int i = 1;
// while(i < array.Length)
// {
//     sum = sum + array[i];
//     i = i + 2;
// }
// Console.WriteLine($"Сумма элементов на нечетных позициях равна: {sum}");


// // =======
// double[] GetDoubleArray(int size)
// {
//     double[] result = new double[size]; 
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().NextDouble();
//     }
//     return result; 
// }    
// double[] array = GetDoubleArray(6); 
// Console.WriteLine($"Массив: {string.Join("; ", array)}");

// double[] CompactArray (double[] array)
// {
//     int sizeNewArray = array.Length;
//     double[] newArray = new double[sizeNewArray];

//    for (int i =0; i < array.Length; i++)
//     {
//         newArray[i] = Math.Round(array[i],4) * 100;
//     }
//     return newArray;
// }    
// Console.WriteLine($"Результат: {string.Join("; ",CompactArray (array))}");
// double[] WorkArray = CompactArray (array);

// double min = WorkArray[0];
// double max = WorkArray[0];
// for (int i =1; i < array.Length; i++)
// {
//     if(WorkArray[i] < min)
//     {
//         min = WorkArray[i];
//     }
//     if(WorkArray[i] > max )
//     {
//         max = WorkArray[i];
//     }
// } 
// Console.WriteLine($"Разница между макс. {max} и миним. {min} элем. {max - min}");

