﻿// Написать программу, которая из имеющегося массива строк формирует
//  новый массив из строк, длина которых меньше, либо равна 3 символам.
//   Первоначальный массив можно ввести с клавиатуры, либо задать 
//   на старте выполнения алгоритма. При решении не рекомендуется
//  пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] basicArray =  {"sheep", "hi", "world", "cat", "dog", "hamster"};

int GetSizeNewArray(string[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] FillResultArray(string[] array, int size)
{
    string[] result = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[result.Length - size] = array[i];
            size--;
        }
    }
    return result;
}  