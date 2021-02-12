using System;
using System.Security.Cryptography.X509Certificates;

namespace lesson11_11._02._21
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, result;
            ShowMath<double> show;

            Console.WriteLine("Enter your numbers");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Choose your operation(+,-,/,*): ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            char cho = char.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            switch (cho)
            {
                case '+':
                    show = DoMath.Add;
                    result = show.Invoke(x, y);
                    Color.Change(ConsoleColor.Green);
                    Console.WriteLine($"{x} + {y} = {result}");

                    break;
                case '-':
                    show = DoMath.Substract;
                    result = show.Invoke(x, y);
                    Color.Change(ConsoleColor.Green);
                    Console.WriteLine($"{x} - {y} = {result}");
                    Color.Change(ConsoleColor.White);
                    break;
                case '*':
                    show = DoMath.Multiply;
                    result = show.Invoke(x, y);
                    Color.Change(ConsoleColor.Green);
                    Console.WriteLine($"{x} * {y} = {result}");
                    Color.Change(ConsoleColor.White);
                    break;
                case '/':
                    show = DoMath.Divide;
                    result = show.Invoke(x, y);
                    Color.Change(ConsoleColor.Green);
                    Console.WriteLine($"{x} / {y} = {result}");
                    Color.Change(ConsoleColor.White);
                    break;
                default:
                    Color.Change(ConsoleColor.Red);
                    Console.WriteLine("Wrong operation!");
                    Color.Change(ConsoleColor.White);
                    break;
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
    class Color
    {
        public static void Change(ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
        }
    }
}
