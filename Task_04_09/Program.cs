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

            Console.Write("Уникальные эдементы массива: ");


            for (int i = 0; i < size; i++)
            {
                bools = false;

                for (int j = 0; j < size; j++)
                {
                    if (i != j && num[i] == num[j])
                    {
                        bools = true;
                        break;
                    }
                }
                if (!bools)
                {
                    Console.Write(num[i] + " ");
                }
            }
        }
    }
}