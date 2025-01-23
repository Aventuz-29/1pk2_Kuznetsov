namespace Task_03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥| для - 4<=x<=4, с шагом h = 0,5.

            double x = -4;
            double h = 0.5;

            Console.WriteLine("Значений функции: y=|x| для - 4<=x<=4, с шагом h = 0,5: \nЗначение:       Ответ: ");

            while (-4 <= x && x <= 4)
            {
                double y = Math.Abs(x);
                Console.WriteLine(x + "\t - \t" + y);
                x += h;
            }
        }
    }
}