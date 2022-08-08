﻿// Задача 1: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пяти значное число: ");
int a = int.Parse(Console.ReadLine());

if (a > 99999 || a<10000) 
    {
    Console.WriteLine("Ваше число имеет более пяти знаков: ");
    }
else
    {
    int a1digit = a / 10000;
    int a2digit = (a / 1000) %10;
    int a3digit = (a / 100) %10;
    int a4digit = (a / 10) %10;
    int a5digit = a %10;

    if (a1digit == a5digit && a2digit == a4digit)
       {
        Console.WriteLine("Данное число является палидромом");
       } 
    else
        {
            Console.WriteLine("Данное число не является палидромом");
        }
    }