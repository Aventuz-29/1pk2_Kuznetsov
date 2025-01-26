namespace Task_04_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*В массиве на 30 элементов содержатся данные по росту учеников в классе. Рост мальчиков условно задан
            отрицательными значениями. Вычислить и вывести количество мальчиков и девочек в классе и средний рост для
            мальчиков и девочек. При выводе избавиться от отрицательных значений.*/

            int size = 30;
            double[] height = new double[size];
            Random rnd = new Random();
            int boys = 0;
            double averageboys = 0;
            int girls = 0;
            double averagegirls = 0;

            for (int i = 0; i < size; i++)
            {
                height[i] = rnd.Next(140, 211);
                height[i] = height[i] / 100;
                height[i] = rnd.Next(0, 2) == 0 ? height[i] : -height[i];

                if (height[i] < 0)
                {
                    averageboys += Math.Abs(height[i]);
                    boys++;
                }
                if (height[i] > 0)
                {
                    averagegirls += Math.Abs(height[i]);
                    girls++;
                }
            }
            averageboys = Math.Round(averageboys / boys, 1);
            averagegirls = Math.Round(averagegirls / girls, 1);

            Console.WriteLine("Количество мальчиков в классе - " + boys + ", их средний рост - " + averageboys + "м.");
            Console.WriteLine("Количество девочек в классе - " + girls + ", их средний рост - " + averagegirls + "м.");
        }
    }
}