namespace Task_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу, которая выводит таблицу скорости(через каждые 0, 5с) свободно падающего тела v = g t ,
            где 2 g = 9,8 м / с2 – ускорение свободного падения.*/

            double g = 9.8;
            double t = 0.5;

            Console.WriteLine("Скорость свободно падающего тела: \nВремя: \t   Скорость: ");

            Console.Write("Введите лимит: ");
            double limit = Int32.Parse(Console.ReadLine());

            while (t <= limit)
            {
                double v = g * t;
                Console.WriteLine(t + "     -     " + v);
                t += 0.5;
            }
        }
    }
}