namespace Task_10_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создать Метод ArrayGeneration не возвращающий значения, принимает целое число n, выводит на консоль сгенерированный массив размерности n*n

            Console.Write("Разерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            ArrayGeneration(n);
        }
        /// <summary>
        /// Метод выводит на консоль сгенерированный массив
        /// </summary>
        /// <param name="n">длинна и ширина массива</param>
        static void ArrayGeneration(int n)
        {
            int[,] array = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(1, 10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }   
}
