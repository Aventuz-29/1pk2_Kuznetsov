namespace Task_05_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Дан квадратный массив размерность n * n. Произведите анализ данной матрицы и выясните является ли данная матрица Z - матрицей
            (это матрица, где все недиагональные элементы меньше нуля)
            Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали.Если не выполняется, то
            вывести сообщение что данная матрица не является Z - матрицей*/

            //Переменные и массивы
            Random rnd = new Random();
            int n = 3;
            int[,] array = new int[n, n];
            bool bools = true;
            int num = 0;

            //Задаем данные в матрицу
            Console.WriteLine("Матрица: ");
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(-10, 10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Проверка является ли матрица Z - матрицей
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i != j && i != n - j - 1 && array[i, j] < 0)
                    {
                        num++;
                    }
                }
            }

            if (n % 2 == 1)
                num--;

            Console.WriteLine("=>");

            if (num == (n * n) - (n * 2))
            {
                bools = false;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(array[i, j]);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                        }
                        else 
                            Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            if (bools)
            {
                Console.Write("Данная матрица не является Z - матрицей!");
            }
            Console.WriteLine();
        }
    }
}