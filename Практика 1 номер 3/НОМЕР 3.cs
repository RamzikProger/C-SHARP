using System;

namespace Практика_1_номер_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите координаты точки 1 (x1, y1):");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты точки 2 (x2, y2):");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double distance = CalculateDistance(x1, y1, x2, y2);

            Console.WriteLine($"Расстояние между точками: {distance:f2}");
        }

        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}