// Задача 8: Напишите программу, которая 
// на вход принимает число (N), а на выходе показывает все чётные 
// числа от 1 до N.
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int i = 0;
if(a > 1)
while(i <= a)
{
    Console.WriteLine(i);
    i=i+2;
}

