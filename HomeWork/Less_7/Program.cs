﻿// Задача 7: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает последнюю цифру этого числа
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(a%10);
