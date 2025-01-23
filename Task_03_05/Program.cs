using System;

namespace Task_03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
            Фаренгейта(F = C * 1,8 + 32).Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
            время работы программы*/

            Console.Write("Введите диапазон: \nОт: ");
            double range_1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.Write("До: ");
            double range_2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.Write("Введите шаг: ");
            double step = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            
            Console.WriteLine("Цельсия - Фаренгейт");
            while (range_1 <= range_2)
            {
                double faren = range_1 * 1.8 + 32;
                Console.WriteLine("  " + range_1 + "\t-    " + faren);
                range_1 += step;
            }
            
            
        }
    }
}