namespace Task_24_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //реализуйте функцию, осуществляющую поиск текста в файле и его замену на значения, введенные пользователем
            string filepath = "data.txt";
            List<string> content = new List<string>
            {
                "Ветер шепчет в тростниках",
                "Тихо плещется река",
                "Ночь накрыла облаками",
                "Как прозрачная рука"
            };
            foreach (string i in content)
            {
                Console.WriteLine(i);
            }
            File.WriteAllLines(filepath, content);

            SearchTexts.searchTexts(filepath);

            Console.WriteLine();
            Console.WriteLine("Измененный текст: ");
            Console.WriteLine(File.ReadAllText(filepath));
        }
    }
}
