using System;

namespace Практика_2_номер_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер 3.");
            int number;
            int sumPositOdd = 0;

            Console.WriteLine("Введите числа. Для окончания введите 0.");

            do
            {
                Console.Write("Введите число: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number > 0 && number % 2 != 0)
                {
                    sumPositOdd += number;
                }
            } while (number != 0);

            Console.WriteLine("Сумма всех нечетных положительных чисел: " + sumPositOdd);

            Console.WriteLine("Номер 4");

            int attempts = 3;
            bool isAuthenticated = false;

            do
            {
                Console.WriteLine($"У вас осталось {attempts} попыток.");

                Console.Write("Введите логин: ");
                string inputLogin = Console.ReadLine();

                Console.Write("Введите пароль: ");
                string inputPassword = Console.ReadLine();

                isAuthenticated = CheckLogin(inputLogin, inputPassword);

                if (!isAuthenticated)
                {
                    Console.WriteLine("Неверный логин или пароль. Попробуйте еще раз.");
                    attempts--;
                }
            } while (!isAuthenticated && attempts > 0);

            if (isAuthenticated)
            {
                Console.WriteLine("Авторизация прошла успешно. Добро пожаловать!");
            }
            else
            {
                Console.WriteLine("Превышено количество попыток входа. Доступ запрещен.");
            }

        }

        static bool CheckLogin (string login, string password)
        {
            // Проверка логина и пароля
            return login == "root" && password == "ITTop";
        }
    }
}