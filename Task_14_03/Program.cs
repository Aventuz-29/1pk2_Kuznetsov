﻿namespace Task_14_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Реализуйте статический метод Factorial, который принимает целое число и
            //возвращает его факториал.Сделайтетак, чтобы метод работал только
            //для неотрицательных чисел.

            Console.WriteLine(Fact.Factorial(3));
            Console.WriteLine(Fact.Factorial(-3));
        }
    }
}