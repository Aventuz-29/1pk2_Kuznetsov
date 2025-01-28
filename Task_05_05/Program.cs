namespace Task_05_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе[n * m].Заполнение
            случайными числами в диапазоне от - 99 до 99 включительно.Осуществите без создания нового массива преобразование текущего
            по следующему правилу:
            • Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
            • Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом*/

            //Запрашиваем у пользователя количество строк и столбцов
            Console.Write("Введите количество строк: ");
            int line = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Введите количество столбцов: ");
            int column = int.Parse(Console.ReadLine());
            Console.Clear();

            Random rnd = new Random();
            int[,] array = new int[line, column];

            //Задаем значение в массив
            Console.WriteLine("Массив: ");
            for(int i = 0; i < line; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    array[i, j] = rnd.Next(-99, 100);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Преобразовываем массив
            Console.WriteLine("=>");
            Console.WriteLine("Массив с преобразованием: ");
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if(array[i, j] < 0)
                    {
                        array[i, j] = Math.Abs(array[i, j]);
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(array[i, j]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }
                    else if(array[i, j] == 0)
                    {
                        array[i, j]++;
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