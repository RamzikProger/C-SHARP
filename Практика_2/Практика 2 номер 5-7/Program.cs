namespace Практика_2_номер_5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Номер 5 \n");

            Console.WriteLine("Введите массу(в кг): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите рост (в метрах) : ");
            double height = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / (height * height);
            string recommendation;
            if (bmi < 18.5)
            {
                recommendation = "набрать вес";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                recommendation = "все в норме";
            }
            else
            {
                recommendation = "похудеть";
            }

            Console.WriteLine($"Индекс массы тела (ИМТ): {bmi:f2}");
            Console.WriteLine($"Рекомендация: {recommendation}");

            if (recommendation == "набрать вес")
            {
                double idealWeight = 24.9 * (height * height); 
                double gainWeight = idealWeight - weight; 
                Console.WriteLine($"Нужно набрать {gainWeight:f2} кг для нормализации веса.\n");
            }
            else if (recommendation == "похудеть")
            {
                double idealWeight = 24.9 * (height * height); 
                double loseWeight = weight - idealWeight;
                Console.WriteLine($"Нужно похудеть на {loseWeight:f2} кг для нормализации веса.\n");
            }

            Console.WriteLine("Номер 6 \n");
            DateTime startTime = DateTime.Now;

            int countOfGoodNumbers = 0;
            for (int i = 1; i <= 1000000000; i++)
            {
                if (IsGoodNumber(i))
                {
                    countOfGoodNumbers++;
                }
            }

            DateTime endTime = DateTime.Now;
            TimeSpan executionTime = endTime - startTime;

            Console.WriteLine($"Количество \"хороших\" чисел: {countOfGoodNumbers}");
            Console.WriteLine($"Время выполнения программы: {executionTime} \n");

            Console.WriteLine("Номер 7 \n");

            int start = 1;
            int end = 10;

            Console.WriteLine("Числа от " + start + " до " + end + ":");
            PrintNumbers(start, end);

            int sum = SumOfNumbers(start, end);
            Console.WriteLine("\nСумма чисел от " + start + " до " + end + " равна: " + sum);
        }


        //метод сумма цифр
        static int SumDigit(int number)
        {
            int sum1 = 0;
            while(number > 0)
            {
                sum1 += number % 10;
                number /= 10;
            }
            return sum1;
        }
        // метод проверки числа
        static bool IsGoodNumber(int number)
        {
            int sum2 = SumDigit(number);
            return number % sum2 == 0;

        }

        // Рекурсивный метод вывода чисел от а до b
        static void PrintNumbers(int a, int b)
        {
            if (a > b)
            {
                return;
            }

            Console.Write(a + " ");
            PrintNumbers(a + 1, b);
        }

        // Рекурсивный метод  суммы чисел от a до b
        static int SumOfNumbers(int a, int b)
        {
            if (a > b)
            {
                return 0;
            }

            return a + SumOfNumbers(a + 1, b);
        }
    }
}