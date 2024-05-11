namespace Практика_2
{
    internal class Program
    {
        
        static int Min_of_three(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }

        static int DigitNum(int d)
        {
            int k = 0;
            while(d > 0)
            {
                d = d / 10;
                k += 1;
            }
            return k;
        }


        static void Main(string[] args)
        {
            int a = 3;
            int b = 7;
            int c = 22;

            int min3 = Min_of_three(a, b, c);
            Console.WriteLine("Минимальное среди трех чисел: "+min3);

            int d = 12345;
            int digits = DigitNum(d);
            Console.WriteLine("Количество цифр: " + digits);
        }
    }
}