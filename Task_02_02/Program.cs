namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Найти значение выражения при a = 8, b = 14, с = π / 4

            //Создаем переменные
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;

            double part_1 = Math.Pow(a - 1, 1.0 / 3.0);
            double part_2 = Math.Pow(b + part_1, 1.0 / 4.0); //числитель
            double part_3 = Math.Abs(a - b);
            double part_4 = Math.Sin(Math.Pow(c, 2)) + Math.Tan(c);
            double part_5 = part_3 * part_4; //знаменатель
            double part_6 = part_2 / part_5; //итог 

            Console.WriteLine(part_6);
        }
    }
}