namespace Task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Пользователь вводить в консоли произвольный текст. После каждого ввода консоль очищается.Когда
            пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк
            введенных пользователем.*/

            int quantity = 0;

            while (true)
            {
                Console.Write("Введите текст: ");
                string text = Console.ReadLine();
                Console.Clear();

                if (text == "exit" || text == "")
                {
                    Console.WriteLine(quantity);
                    break;
                }
                else quantity++;
            }
        }   
    }
}