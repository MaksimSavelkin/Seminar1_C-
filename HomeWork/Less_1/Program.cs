// Задание на проверку числа
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());

if (b == a * a)
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("да");
}