namespace Task_05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Осуществить генерация двумерного[10 * 5] массива по следующему правилу:
            • 1 столбец содержит нули
            • 2 столбце содержит числа кратные 2
            • 3 столбец содержит числа кратные 3
            • 4 столбец содержит числа кратные 4
            • 5 столбец содержит числа кратные 5
            Осуществить переворот массива(поменять строки и столбцы местами) вывести обновленный массив*/

            int a = 10;
            int b = 5;
            Random rnd = new Random();
            int[,] array = new int[a, b];

            //Задаем массив
            Console.WriteLine("Массив: ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    array[i, j] = rnd.Next(0, 10);
                    if (j == 0)
                        array[i, j] = 0;

                    else if (j == 1 && (array[i, j] % 2 != 0 || array[i, j] == 0))
                        array[i, j] = (array[i, j] + 2) * 2;

                    else if (j == 2 && (array[i, j] % 3 != 0 || array[i, j] == 0))
                        array[i, j] = (array[i, j] + 2) * 3;

                    else if (j == 3 && (array[i, j] % 4 != 0 || array[i, j] == 0))
                        array[i, j] = (array[i, j] + 2) * 4;

                    else if (j == 4 && (array[i, j] % 5 != 0 || array[i, j] == 0))
                        array[i, j] = (array[i, j] + 2) * 5;

                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("=>");
            int[,] array2 = new int[b, a];
            
            //Переворот массива
            Console.WriteLine("Массив после переворота: ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    array2[j, i] = array[i, j];
                }
            }
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(array2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}