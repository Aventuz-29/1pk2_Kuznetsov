namespace Task_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Дан квадратный массив размерность n * n. Произведите анализ данной матрицы и выясните является ли данная матрица
            диагональной(все элементы вне главной диагонали равны нулю)
            Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
            сообщение что матрица не является диагональной.*/
            
            Console.Write("Введите размерность массива(n * n): ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            int[,] array = new int[n, n];
            Random rnd = new Random();
            bool bools = true;

            Console.WriteLine("Матрица: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(0, 10); // для проверки главной диагонали уменьшите значиние до 1) 
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Проверка на то является ли матрица диагональной
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && array[i, j] != 0) 
                    {
                        bools = false;
                        Console.WriteLine("=>");
                        Console.WriteLine("Матрица не является диагональной!");
                        break;
                    }
                }
                if (bools == false)
                    break;
            }

            //Вывод матрицы с выделенной главной диагональной
            if (bools)
            {
                Console.WriteLine("=>");
                Console.WriteLine("Матрица является диагональной, главная диагональ выделена красным цветом: ");
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
        }
    }
}