namespace Task_10_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте метод с помощью которого можно сгенерировать и вернуть символьный 
             * двумерныймассив(состоящийиз символов русского алфавита) и выведите на 
             * консоль данный массив с помощью другого метода(которыйпринимает данный массив в качестве параметра)*/

            Console.Write("Введите количество строк массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов массива: ");

            int m = Convert.ToInt32(Console.ReadLine());
            char[,] array1 = ArrayСhar(n, m);
            ArrayСonclusion(array1);
        }
        /// <summary>
        /// Метод генерирует и возвращает двумерный массив
        /// </summary>
        /// <param name="n"> количество строк массива</param>
        /// <param name="m"> количество столбцов массива</param>
        /// <returns>символьный массив</returns>
        static char[,] ArrayСhar(int n, int m)
        {
            char[,] array = new char[n, m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = (char)rnd.Next('а', 'я' + 1);
                }
            }
            return array;
        }
        /// <summary>
        /// Принимает и выводит массив
        /// </summary>
        /// <param name="array">символьный массив</param>
        static void ArrayСonclusion(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
