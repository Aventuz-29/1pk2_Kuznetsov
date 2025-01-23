namespace Task_03_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Даны натуральные числа от 20 до 50.Напечатать те из них, которые делятся на 3, но не делятся на 5.

            int num = 20;

            Console.Write("Числа которые делятся на 3, но не делятся на 5: ");

            for (int i = num; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                    Console.Write(i + ", ");
            }
        }
    }
}