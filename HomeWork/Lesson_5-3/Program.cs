// Задача 3: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным элементов массива.

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

int[] Razn(int[] arr)
{
    int min = 0;
    int max = 0;
    int i = 0;
    if()
       
        
    return new_arr;
}
int[] arr_1 = RandomArray();
Print(arr_1);
int[] new_arr_1 = ParisNum(arr_1);
Print(new_arr_1);