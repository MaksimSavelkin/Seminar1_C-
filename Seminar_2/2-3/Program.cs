﻿// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число 
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деление.
void Method (int a, int b)
{
    if (a % b == 0)
        Console.WriteLine("Кратно");
    else 
        Console.WriteLine($"Не кратно {a % b}");
}
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Method(a, b);


