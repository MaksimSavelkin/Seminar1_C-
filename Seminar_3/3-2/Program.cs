// Задача 2: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
double Coordinat (double x1, double y1, double x2, double y2) 
{
    return  Math.Round(Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2)),2);
}
Console.WriteLine(Coordinat(3, 6, 2, 1));