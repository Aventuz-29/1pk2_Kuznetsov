namespace Task_04_05
{
    internal class Program
    {
        static void Main (string[] args)
        {
            /*В массиве хранятся сведения о количестве осадков за месяц(30 дней).Необходимо определить общее
            количество осадков, выпавших за каждую декаду месяца, вывести день с самыми сильными осадками за месяц и
            отдельно вывести дни без осадков.Массив с осадками заполнятся с помощью рандома в диапазоне от 0 – нет
            осадков, до 300 мм выпавших осадков.*/

            int[] weather = new int[30];
            Random rnd = new Random();

            int a = 0; 
            int b = 0;
            int c = 0;
            int max = -1;
            int index = 0;

            for (int i = 0; i < weather.Length; i++)
            {
                weather[i] = rnd.Next(0,301);
            }

            for (int j = 0; j < 10; j++)
            {
                a += weather[j];
            }
            Console.WriteLine("Количество осадков за 1 декаду: " + a);

            for (int j = 10; j < 20; j++) 
            { 
                b += weather[j];
            }
            Console.WriteLine("Количество осадков за 2 декаду: " + b);

            for (int j = 20; j < 30; j++)
            {
                c += weather[j];
            }
            Console.WriteLine("Количество осадков за 3 декаду: " + c);
            
            for (int r = 0; r < weather.Length; r++)
            {
                if(max <= weather[r])
                {
                    max = weather[r];
                    index = r + 1;
                }
            }
            Console.WriteLine("Максимальное количество осадков было в " + index + " день.");

            Console.Write("В эти(этот) дни(день) не было осадков: ");
            for (int r = 0; r < weather.Length; r++)
            {
                if (weather[r] == 0)
                    Console.Write(r + 1 + " ");
            }




        }
    }
}