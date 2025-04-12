using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_10
{
    class SumDictionary
    {
        /// <summary>
        /// Метод объединяет словари
        /// </summary>
        /// <param name="dict1">Первый словарь</param>
        /// <param name="dict2">Второй словарь</param>
        /// <returns>Итоговый словарь</returns>
        public Dictionary<string, int> Sumdictionary(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
        {
            var result = dict1;
            foreach(var i in dict2)
            {
                if (result.ContainsKey(i.Key))
                {
                    int value1 = result[i.Key];
                    int value2 = i.Value;
                    result[i.Key] = value1 + value2;
                }
                else
                    result.Add(i.Key, i.Value);
            }
            return result;
        }
    }
}
