using System;
using System.Threading;

namespace Lab_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Пожжалуйста, введите число для преобразования в факториал");
            PrintItCoulorfull(GetFactorial(GerRightVal(Console.ReadLine())));
        }
        static long GetFactorial(int val)
        {
            long result =1;
            for (int i = 1; i < val; i++)
            {
                result = result * i;
            }
            return result;
        }
        static void PrintItCoulorfull (long input)
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                PrintFactorial(input);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                PrintFactorial(input);
            }
        }
        static void PrintFactorial(long input)
        {
            Console.Clear();
            string InputLenght = Convert.ToString(input);
            Console.Write("+");
            for (int i = 0; i != (InputLenght.Length + 2); i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
            Console.Write("| ");
            Console.Write(input);
            Console.WriteLine(" |");
            Console.Write("+");
            for (int i = 0; i != (InputLenght.Length + 2); i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
            System.Threading.Thread.Sleep(200);
        }
        static int GerRightVal (string input)
        {
            int result;
            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Возможно, вы ошиблись. Пожалуйста, введите значение ещё раз.");
                input = Console.ReadLine();
            }
            return result;
        }
    }
}
