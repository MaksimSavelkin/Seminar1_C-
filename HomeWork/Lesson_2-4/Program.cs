﻿// Задача 4: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7: ");
int a = int.Parse(Console.ReadLine());
if (a > 5)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Будни");
}

