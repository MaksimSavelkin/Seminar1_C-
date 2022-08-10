// Задача 2: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве
void Print(int[] arr)
{
    int size = arr.Length;

    for(int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for(int i = 0; i < size; i ++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

void Perebor(int[] arr, int num)
{
    
    for(int i = 0; i < arr.Length; i++)
        if(arr[i] == num)
            Console.WriteLine("Да");
        else
            Console.WriteLine("Нет");
               
    
}
int[] arr_1 = MassNums(12, -9, 10);
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Print(arr_1);
Perebor(arr_1, num);

