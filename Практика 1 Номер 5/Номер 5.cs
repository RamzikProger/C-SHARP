using System;

namespace Практика_1_Номер_5
{
    

    class Program
    {
        static void Main()
        {
            string name = "Иван";
            string surname = "Иванов";
            string city = "Москва";

            // Часть а
            Console.WriteLine("Часть а: Простой вывод");
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Фамилия: " + surname);
            Console.WriteLine("Город проживания: " + city);
            Console.WriteLine();

            // Часть б
            Console.WriteLine("Часть б: Вывод в центре экрана с использованием позиционирования");
            PrintCentered("Имя: " + name);
            PrintCentered("Фамилия: " + surname);
            PrintCentered("Город проживания: " + city);
            Console.WriteLine();

            // Часть в
            Console.WriteLine("Часть в: Вывод в центре экрана с использованием собственного метода");
            PrintCenteredCustom("Имя: " + name);
            PrintCenteredCustom("Фамилия: " + surname);
            PrintCenteredCustom("Город проживания: " + city);
        }

        // Метод для вывода текста в центре экрана с использованием позиционирования
        static void PrintCentered(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);
        }

        // Метод для вывода текста в центре экрана с использованием собственного метода
        static void PrintCenteredCustom(string text)
        {
            Console.WriteLine(text.PadLeft((Console.WindowWidth + text.Length) / 2));
        }
    }

}