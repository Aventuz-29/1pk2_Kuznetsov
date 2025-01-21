namespace Task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Пользователь вводить в консоли произвольный текст. После каждого ввода консоль очищается.Когда
            пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк
            введенных пользователем.*/

            while (true)
            {

                Console.Write("Введите текст: ");
                string text = Console.ReadLine();
                Console.Clear();

                int quantity = 0;

                while (text != "exit" || text != null)
                {
                    quantity++;
                    Console.Write("Введите текст: ");
                    text = Console.ReadLine();
                    Console.Clear();
                }
                Console.WriteLine(quantity);
                break;
            }
        }   
    }
}