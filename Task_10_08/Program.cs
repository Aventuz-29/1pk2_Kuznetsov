namespace Task_10_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте метод, который на вход принимает одномерный массив и число для поиска,
            //верните индексискомогоэлемента в массиве. Если элемента нет – верните индекс = -1
            Random rnd = new Random();
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                array[i] = rnd.Next(1, 11);
            }
            Console.Write("Введите число для поиска от 1 до 10: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int index = Search(array, num);
            Console.WriteLine("Индекс числа: " + index);
        }
        /// <summary>
        /// Метод ищет нужное число в массиве
        /// </summary>
        /// <param name="array">массив с числами</param>
        /// <param name="num">число которое надо найти</param>
        /// <returns>если нудное число в массиве есть, то возвращается его индекс, иначе возвращается -1</returns>
        static int Search(int[] array, int num)
        {
            bool bools = true;
            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine(array[i]); //для проверки
                if (array[i] == num)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}