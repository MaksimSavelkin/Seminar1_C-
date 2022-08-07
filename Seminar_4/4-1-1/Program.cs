// Задача 1: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
void Leng(int num)
{
    string num1 = num.ToString();
    Console.WriteLine(num1.Length);
}

Leng(4521);