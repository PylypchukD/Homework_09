using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        private delegate int MyDelegate();
        private delegate double Delegates(MyDelegate[] del);

        private static int Random()
        {
            Random rnd = new Random();
            return rnd.Next(0, 10);
        }
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает среднее арифметическое возвращаемых значений методов, 
             * сообщенных с делегатами в массиве. 
             * Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int. 
             */

            MyDelegate[] arrayDel = new MyDelegate[Random()];
            for (int i = 0; i < arrayDel.Length; i++)
            {
                arrayDel[i] = () =>
                {
                    return new MyDelegate(Random).Invoke();
                };
            }

            Delegates delegates = delegate(MyDelegate[] del)
            {
                double average = 0;
                for (int i = 0; i < del.Length; i++)
                {
                    average += del[i].Invoke();
                }
                return average / del.Length;
            };

            for (int i = 0; i < arrayDel.Length; i++)
            {
                Console.Write(arrayDel[i].Invoke() + " ");
            }

            Console.WriteLine($"\nСреднее арифметическое: {delegates(arrayDel)}");

            Console.ReadKey();

        }
    }
}
