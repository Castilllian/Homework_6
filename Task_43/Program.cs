// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.Write("Введите число b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите число k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите число b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.Write("Введите число k2: ");
int k2 = int.Parse(Console.ReadLine());

float PointCross(int b1, int k1, int b2, int k2)
{
    if(k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    if(k1==k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        float x = (b2-b1)/(k1-k2);
        float y = (k1*(b2-b1))/(k1*x+b1);
    }
    return 0;
}
Console.WriteLine($"Точкой пересечения двух линей станет: {PointCross(b1, k1, b2, k2)}");