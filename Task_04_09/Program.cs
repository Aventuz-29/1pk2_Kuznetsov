using System.ComponentModel.Design;
using System.Numerics;
using System.Xml;

namespace Task_04_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*В массиве найти элементы, которые в нем встречаются только один раз, и вывести их на экран. То есть найти и
            вывести уникальные элементы массива.*/

            int size = 50;
            int[] num = new int[size];
            bool bools;
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                num[i] = rnd.Next(1, 101);
            }

            Array.Sort(num);
            foreach (int i in num)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                bools = true;

                for (int j = 0; j < size; j++)
                {
                    if (i != j && num[i] == num[j])
                    {
                        bools = false;
                        break;
                    }
                }
                if (bools)
                {
                    Console.Write(num[i] + " ");
                }
            }
        }
    }
}