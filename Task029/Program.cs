﻿/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
*/

int [] getRange(int length)
{
    int [] array = new int [length];
    Random rd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rd.Next(0, 9);
    }
    return array;
}

void printArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int [] array = getRange(8);
printArray(array);