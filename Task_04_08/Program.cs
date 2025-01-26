using System.Collections.Immutable;
using System.Numerics;

namespace Task_04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Дан массив, содержащий последовательность 50 случайных чисел. Найти количество пар элементов, значения
            которых равны.*/

            int size = 50;
            int[] num = new int[size];
            bool[] bools = new bool[30];
            int couples = 0;
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                num[i] = rnd.Next(1, 101);
            }

            Array.Sort(num);
            
            for (int i = 1; i < size; i++)
            {
                
                if (num[i] == num[i - 1])
                {
                    couples++;
                    i++;
                }
            }
            Console.WriteLine(couples);
        }
    }
}