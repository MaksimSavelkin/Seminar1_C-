// Задача 1: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

void Quartets(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x =0; y = 0");
    else if (x > 0 && y > 0)
            Console.WriteLine("1");
    else if (x < 0 && y > 0)
            Console.WriteLine("2");
    else if (x < 0 && y < 0)
            Console.WriteLine("3");
    else if (x > 0 && y < 0)
            Console.WriteLine("4");  
}

Quartets(0, 9);
Quartets(1, 9);
Quartets(-2, 9);
Quartets(2, -9);
Quartets(-3, -9);