// Задача 1: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.
int Stepen(int a, int b)
{
    int Step = a;
    for(int i = 2; i <= b; i++)
        Step *= a;
    return Step;
}
Console.WriteLine(Stepen(3, 5));
