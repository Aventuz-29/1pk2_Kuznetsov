using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_07
{
    class DictionaryHelper
    {
        /// <summary>
        /// Метод для нахождения ключа в словаре
        /// </summary>
        /// <param name="dictionary">Словарь</param>
        /// <param name="meaning">Значение</param>
        /// <returns></returns>
        public string FindingKey(Dictionary<string, int> dictionary, int meaning)
        {
            foreach (var pair in dictionary)
            {
                if (pair.Value == meaning)
                {
                    Console.WriteLine(pair.Key);
                    return (pair.Key);
                }
            }
            return null;
        }
    }
}
