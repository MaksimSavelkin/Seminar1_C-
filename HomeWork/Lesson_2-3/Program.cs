// Задача 3: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.
void Method3(int a)
{
    Console.Write($"{a} = ");
    if (a < 99)
    {
        Console.WriteLine("Число имеет менее трех знаков");
        return;

    }
    while(a > 999) a = a / 10;
    Console.WriteLine(a % 10);
}

Method3(int.Parse(Console.ReadLine()));
