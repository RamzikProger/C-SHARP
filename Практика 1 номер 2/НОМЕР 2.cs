using System;

namespace Практика_1_номер_2
{
    class Program
        {
            static void Main()
            {
                Console.WriteLine("Введите ваш вес (в кг):");
                double weight = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите ваш рост (в метрах):");
                double height = double.Parse(Console.ReadLine());

                double bmi = weight / (height * height);

                Console.WriteLine($"Ваш индекс массы тела (ИМТ): {bmi:F2}");
            }
        }

}
