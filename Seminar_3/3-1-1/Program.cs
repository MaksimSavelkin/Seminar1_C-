﻿// Задача 1: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

void Quartets(int num)
{
    if (num == 1)
        Console.WriteLine("x > 0 y > 0");
    else if (num == 2)
        Console.WriteLine("x > 0 y < 0");
    else if (num == 3)
        Console.WriteLine("x < 0 y > 0");
    else if (num == 4)
        Console.WriteLine("x < 0 y < 0"); 
}

Quartets(4);
Quartets(3);
Quartets(2);
Quartets(1);
