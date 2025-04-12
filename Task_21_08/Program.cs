namespace Task_21_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишите метод, который на вход получается массив параметров(строк) и возвращает только уникальные строки

            string[] fruits = { "banana", "apple", "pear", "apple", "banana", "apple" }; // Массив строк

            UniqueStrings uniqueStrings = new UniqueStrings();
            HashSet<string> result = uniqueStrings.UniqueString(fruits); // Результат
            foreach(string j in result)
                Console.WriteLine(j);

        }
    }
}
