namespace Task_05_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе[n * n].Заполнение случайными
            числами в диапазоне от 10 до 99 включительно.
            Найти и вывести отдельно минимальный элемент в матрице(LINQ под запретом) Осуществить умножение матрицы на ее
            минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве*/

            //Запрашиваем размер матрицы у пользователя
            Console.Write("Введите размерность массива(n * n): ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

            int[,] array = new int[n, n];
            Random rnd = new Random();
            int minimal = 100;

            //Задаем значение массиву и находим минимальное число массива
            Console.WriteLine("Массив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) 
                { 
                    array[i, j] = rnd.Next(10, 100);
                    Console.Write(array[i, j] + " ");

                    if (minimal >= array[i, j])
                    {
                        minimal = array[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("=>");

            Console.Write("Минимальный элемент в матрице: " + minimal);
            Console.WriteLine();
            Console.WriteLine("=>");

            //Доп массивы
            int[,] array2 = new int[n, n];
            int[] array3 = new int[5];
            bool[] bools = new bool[5];

            //Умножаем матрицу на минимальное число
            Console.WriteLine("Матрица после умножения на ее минимальный элемент: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array2[i, j] = array[i, j] * minimal;
                    
                    if (array3[0] <= array2[i, j])
                    {
                        array3[0] = array2[i, j];
                        Array.Sort(array3);
                    }
                }
            }

            //Выводим 5 максимальных значений
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int p = 0; p < 5; p++)
                    {   
                        if (array2[i, j] == array3[p] && bools[p] == false)
                        {
                            bools[p] = true;
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(array2[i, j]);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                            break;
                        }
                        else if(p == 4)
                            Console.Write(array2[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}