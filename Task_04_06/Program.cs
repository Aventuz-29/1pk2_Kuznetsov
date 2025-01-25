using System.Security.Cryptography;

namespace Task_04_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Заполнить массив случайными положительными и отрицательными числами таким образом, чтобы все числа по
            модулю были разными.Это значит, что в массиве не может быть ни только двух равных чисел, но не может быть
            двух равных по модулю.В полученном массиве найти наибольшее по модулю число.*/

            int size = 5;
            int[] num = new int[size];
            bool[] bools = new bool[20];
            Random rnd = new Random();
            int max = -21;
            
            for (int i = 0; i < size; i++)
            {
                int NumRnd;

                do
                {
                    NumRnd = rnd.Next(1, 21);
                }
                while (bools[NumRnd]);
                bools[NumRnd] = true;

                num[i] = rnd.Next(0, 2) == 0 ? NumRnd : -NumRnd; 
            }

            Console.Write("Массив со случайными значениями: ");
            foreach (int i in num)
            {
                Console.Write(i + " ");
            }

            for (int i = 0; i < size; i++)
            {
                if (max <= Math.Abs(num[i]))
                {
                    max = Math.Abs(num[i]);
                }
            }
            Console.WriteLine("\nНаибольшее по модулю число в массиве: " + max);
        }
    }
}