// Задача 3: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N
void Cvadrat (int N)
{
    int i = 1;
    while (i <= N)
    {
        Console.WriteLine(Math.Pow(i, 2));
        i ++;

    }

}
Cvadrat(5);