using System;

namespace Практика_1_номер_4
{
    internal class Program
    {
        static void Main()
        {
            int a, b, temp;

            Console.WriteLine("Введите значение переменной a:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение переменной b:");
            b = int.Parse(Console.ReadLine());

            // Обмен значениями с использованием третьей переменной

            Change2(ref a, ref b);
            Console.WriteLine($"После обмена: a = {a}, b = {b}");
            Change3(ref a, ref b);
            Console.WriteLine($"После 2-ого обмена : a = {a}, b = {b}");
        }

        static void Change3(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Change2(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }

}