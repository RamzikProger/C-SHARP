using System;

namespace Практика_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию:");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш рост (в см):");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш вес (в кг):");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Ваше имя: " + name + ", ваша фамилия: " + surname + ", ваш возраст: " + age + ", ваш рост: " + height + " см, ваш вес: " + weight + " кг.");

            Console.WriteLine("Ваше имя: {0}, ваша фамилия: {1}, ваш возраст: {2}, ваш рост: {3} см, ваш вес: {4} кг.", name, surname, age, height, weight);

            Console.WriteLine($"Ваше имя: {name}, ваша фамилия: {surname}, ваш возраст: {age}, ваш рост: {height} см, ваш вес: {weight} кг.");
        }
    }
}