// Задача 3: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99]. 
int[] RandomArray()
{
    Console.WriteLine("Imput number of elements");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine("Imput element's min");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Imput element's max");
    int max = int.Parse(Console.ReadLine());
    int [] array = new int[num];
    for(int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(min, max);
        Console.Write($"{array[i]}");
    }
    return(array);
}

void Print(int[] arr)
{
    int size = arr.Length;

    for(int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}

int Nums(int [] aray)
{
    int count = 0;
    for(int i = 0; i < aray.Length; i++)
    {
        if(aray[i] >= 10 && aray[i] <= 99)
        count++;
    }
    return count;
    
}
int[]aray_1 = RandomArray();
Print(aray_1);
Nums(aray_1);
Console.WriteLine(Nums(aray_1));

