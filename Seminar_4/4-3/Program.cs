﻿// Задача 3: Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и
// единицами в случайном порядке.
void Rundom01Array(int num)
{
    int[] array = new int[num];
    for(int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write($"{array[i]}");
    }
}
Rundom01Array(25);