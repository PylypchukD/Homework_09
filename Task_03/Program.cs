using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и возвращает среднее арифметическое этих аргументов.
             */

            Console.Write("Введите первое число: ");
            int.TryParse(Console.ReadLine(), out int num1);

            Console.Write("Введите второе число: ");
            int.TryParse(Console.ReadLine(), out int num2);

            Console.Write("Введите третье число: ");
            int.TryParse(Console.ReadLine(), out int num3);

            MathActions mathActions = (a, b, c) => (double)(a + b + c)/3;
            Console.WriteLine($"Среднее арифметическое: {mathActions(num1, num2, num3)}");

            Console.ReadKey();
        }

        private delegate double MathActions(int a, int b, int c);

    }
}
