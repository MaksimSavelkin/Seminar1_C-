// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



void SumNum (int m, int n, int sum)
{
    if (n >= m) 
    {
        sum = sum + (m++);
        SumNum(m, n, sum);
        return;
    }
    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
}

Console.WriteLine("Введите начальное число M:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int n = int.Parse(Console.ReadLine());

SumNum(m, n, 0);
