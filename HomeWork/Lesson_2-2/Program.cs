// Задача 2: Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа.
void Method2(int a)
{
    Console.Write(a / 100);
    Console.Write(a % 10);
    Console.WriteLine(" ");
    
}
int a = new Random().Next(100, 999);
Console.WriteLine(a);
Method2(a);