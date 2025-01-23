namespace Task_03_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
             /*Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек
             отбрасывается.Каждый год сумма вклада становится больше. Определите, через сколько лет вклад составит не
             менее y рублей. Примеры
             входные данные
             100
             10
             200
             выходные данные
             8*/

            Console.Write("Вклад в банке(руб): ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.Write("На сколько процентов увеличивается ежегодно: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.Write("Сколько вы хотите получить с вклада: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            int i = 0;
            double z = 0;

            while (x < y)
            {
                x += x * p / 100;
                z = x % 1;
                x -= z;
                i++;
            }
            Console.WriteLine("Вы получите свой доход через(лет): " + i);

        }
    }
}