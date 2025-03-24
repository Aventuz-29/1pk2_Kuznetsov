using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_03
{
    class Fact
    {
        /// <summary>
        /// метод находит факториал числа пользователя
        /// </summary>
        /// <param name="n">факториал</param>
        /// <returns></returns>
        public static long Factorial(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Ошибка: факториал определен только для неотрицательных чисел.");
            }

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}