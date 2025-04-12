namespace Task_24_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишите метод, который принимает путь к файлу и возвращает количество строк в нем. Используйте StreamReader.
            string filePath = "data.txt";
            string contents = "он\n она\n они";

            using (File.Create(filePath)) { }
            Console.WriteLine($"Пустой файл создан: {filePath}");
            Console.WriteLine($"Текст:\n \"{contents}\" в файл {filePath} записан.");
            File.WriteAllText(filePath, contents);

            NumberRows numberRows = new NumberRows();
            int result = numberRows.Numberrows(filePath);
            Console.WriteLine($"Количество строк в файле: {result}");
        }
    }
}
