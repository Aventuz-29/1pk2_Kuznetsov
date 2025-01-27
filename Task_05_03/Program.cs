namespace Task_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Даны два массива, заполненные символами английского алфавита размером 3 * 3.Проверить, являются ли матрицы равными, если
            да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
            элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны.*/

            char[,] one = new char[3, 3];
            char[,] two = new char[3, 3];
            Random rnd = new Random();
            int num = 0;

            /*Если надо проверить на то что матрицы равны или нет(если вы проверяете через ручное задания массива и
            комментируете часть кода где создаются массивы, то изначальные массивы выводится не будут!!!*/

            /*char[,] one = { { 'a', 's', 'd'},{ 'a', 's', 'd'},
            { 'a', 's', 'd'} };
            char[,] two = { { 'a', 's', 'd'},{ 'a', 's', 'd'},
            { 'a', 's', 'd'} };*/

            //Создание двух массивов
            for (int i = 0; i < one.GetLength(0); i++)
            {
                for (int j = 0; j < one.GetLength(1); j++)
                {
                    one[i, j] = (char)rnd.Next('a', 'z' + 1);

                    Console.Write(one[i, j] + " ");
                }

                Console.Write("   ");

                for (int p = 0; p < two.GetLength(1); p++)
                {
                    two[i, p] = (char)rnd.Next('a', 'z' + 1);
                    Console.Write(two[i, p] + " ");
                }

                Console.WriteLine();
            }

            //Проверка на то равны ли матрицы
            for (int i = 0; i < one.GetLength(0); i++)
            {
                for (int j = 0; j < one.GetLength(1); j++)
                {

                    if (one[i, j] == two[i, j])
                    {
                        num++;
                    }

                }
                if (num == one.GetLength(0) * one.GetLength(1))
                {
                    Console.WriteLine("Матрицы равны!");
                    break;
                }
            }

            //Матрицы с цветовой индикацией
            if (num != one.GetLength(0) * one.GetLength(1))
            {
                Console.WriteLine("=>");
                for (int i = 0; i < one.GetLength(0); i++)
                {
                    for (int j = 0; j < one.GetLength(1); j++)
                    {
                        if (one[i, j] == two[i, j])
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(one[i, j]);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                        }
                        else Console.Write(one[i, j] + " ");
                    }

                    Console.Write("   ");

                    for (int p = 0; p < two.GetLength(1); p++)
                    {
                        if (one[i, p] == two[i, p])
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(two[i, p]);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                        }
                        else Console.Write(two[i, p] + " ");
                    }

                    Console.WriteLine();
                }

            }
        }
    }
}