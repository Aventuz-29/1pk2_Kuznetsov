namespace Task_05_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Даны два массива размером 10 * 10, заполненные целыми числами в диапазоне от 1 до 9 вкл.Создать новый массив, который будет
            произведением двух предыдущих(перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в
            результирующий массив)
            Вывести результирующий массив*/

            //Переменные и массивы
            int a = 10;
            int[,] array1 = new int[a, a];
            int[,] array2 = new int[a, a];
            int[,] array3 = new int[a, a];
            Random rnd = new Random();

            //Задаем значение массивам
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    array1[i, j] = rnd.Next(1, 10);
                    array2[i, j] = rnd.Next(1, 10);
                }
            }
            
            //Два массива, для проверки

            /*Первый массив
            Console.WriteLine("Массив_1: ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(array1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Второй массив
            Console.WriteLine("Массив_2: ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(array2[i, j] + " ");
                }
                Console.WriteLine();
            }*/

            //Результат
            Console.WriteLine("Результирующий массив: ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    array3[i, j] = array1[i, j] * array2[i, j];
                    Console.Write(array3[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}