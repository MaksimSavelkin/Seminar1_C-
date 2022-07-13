// Задача 4: Напишите программу, 
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine(a);
    }
    else
    {
        Console.WriteLine(c);
    }
}
else if  (b > c)
{
    Console.WriteLine(b);
}
else if (c > a)
{
    Console.WriteLine(c);
}


