namespace Task_04_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Заполнить массив из 10 элементов случайными числами в интервале[-10..10] и сделать реверс элементов
            отдельно для 1 - ой и 2 - ой половин массива. Реверс реализовать через цикл. Стандартные методы класса Array
            использовать нельзя.*/

            int[] num = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rnd.Next(-10, 11);
            }
            Console.Write("Массив до реверса: ");
            foreach (int i in num)
            {
                Console.Write(i + " ");
            }
            for (int i = 0; i < 2; i++)
            {
                int temp = num[i];
                num[i] = num[4 - i];
                num[4 - i] = temp;
            }
            for(int i = 0; i < 2; i++)
            {
                int temp = num[5 + i];
                num[5 + i] = num[9 - i];
                num[9 - i] = temp;
            }
            Console.WriteLine();
            Console.Write("Массив после реверса: ");
            foreach (int i in num)
            {
                Console.Write(i + " ");
            }
        }
    }
}