using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_08
{
    class UniqueStrings
    {
        HashSet<string> sorting = new HashSet<string>(); // Множество

        /// <summary>
        /// Метод отбирает только уникальные строки и возвращает пользователю
        /// </summary>
        /// <param name="array">Массив пользователя</param>
        /// <returns>Уникальные строки</returns>
        public HashSet<string> UniqueString(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                sorting.Add(array[i]);
            }
            return sorting;
        }
    }
}
