using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Program
    {

        private delegate double MathActions(int a, int b);

        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Создайте четыре лямбда оператора для выполнения арифметических действий: 
             * (Add – сложение, Sub – вычитание, Mul – умножение, Div – деление). 
             * Каждый лямбда оператор должен принимать два аргумента и возвращать результат вычисления. 
             * Лямбда оператор деления должен делать проверку деления на ноль. 
             * Написать программу, которая будет выполнять арифметические действия, указанные пользователем. 
             */
            
            MathActions mathActions = null;

            Console.Write("Введите первое число: ");
            int.TryParse(Console.ReadLine(), out int num1);

            Console.Write("Введите второе число: ");
            int.TryParse(Console.ReadLine(), out int num2);

            Console.Write("Введите метод (Add, Sub, Mul, Div): ");
            string operationName = Console.ReadLine();

            switch (operationName)
            {
                case "Add":
                    mathActions = (x,y) => { return x + y; };
                    break;
                
                case "Sub":
                    mathActions = (x,y) => { return x - y; };
                    break;
               
                case "Mul":
                    mathActions = (x,y) => { return x * y; };
                    break;
               
                case "Div":
                    mathActions = (x,y) => { 
                        if (y==0)
                            return 0; 
                        else
                            return (double) x / y; 
                    };
                    break;
               
                default:
                    Console.WriteLine("Операция не найдена");
                    break;
            }

            if (mathActions != null)
            {
                Console.WriteLine($"Результат: {mathActions(num1, num2)}");
            }

            Console.ReadKey();
        }


    }
}
