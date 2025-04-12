namespace Task_24_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Реализуйте функцию, которая ищет заданное слово в текстовом файле и возвращает все строки, содержащие это слово (регистронезависимо)

            string filepath = "data.txt";
            List<string> content = new List<string>
            {
                "Ветер шепчет в тростниках",
                "Тихо плещется река",
                "Ночь накрыла облаками",
                "Как прозрачная рука"
            };
            foreach(string i in content)
            {
                Console.WriteLine(i);
            }
            File.WriteAllLines(filepath, content);
            List<string> result = WordSearch.wordSearch(filepath);
            Console.WriteLine("\nСтрока(и) с вашим словом: ");
            foreach (string i in result)
                Console.WriteLine($"- {i}");
        }
    }
}
