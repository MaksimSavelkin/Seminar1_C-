﻿// Задача 2: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Write a number: ");
int a = int.Parse(Console.ReadLine());

int sum = 0;
while (a > 0) 
{
    sum += a % 10;
    a /= 10;
}

Console.WriteLine (sum);