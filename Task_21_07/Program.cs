namespace Task_21_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Написать метод, который находит первый ключ в словаре, соответствующий заданному значению. Если значения нет, вернуть null.

            // Словарь
            Dictionary<string, int> Dictionary = new Dictionary<string, int>
            {
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"anotherThree", 3}
            };

            int meaning = 2;// Переменная значения

            DictionaryHelper dictionaryHelper = new DictionaryHelper();
            dictionaryHelper.FindingKey(Dictionary, meaning);
        }
    }
}
