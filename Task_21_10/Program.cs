namespace Task_21_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написать метод, который объединяет два словаря. Если ключ присутствует в обоих словарях, суммировать их значения.

            var dict1 = new Dictionary<string, int>
            {
            {"a", 1},
            {"b", 2},
            {"c", 3}
            };

            var dict2 = new Dictionary<string, int>
            {
            {"a", 10},
            {"d", 4},
            {"e", 5}
            };
            SumDictionary sumDictionary = new SumDictionary();
            var result = sumDictionary.Sumdictionary(dict1, dict2);

            Console.WriteLine("Объединенные словари: ");
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
