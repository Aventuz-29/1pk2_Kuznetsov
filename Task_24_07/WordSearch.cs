using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task_24_07
{
    class WordSearch
    {
        /// <summary>
        /// Метод ищет слово в строке
        /// </summary>
        /// <param name="filepath">имя файла со строками</param>
        /// <returns>массив со строками</returns>
        public static List<string> wordSearch(string filepath)
        {
            List<string> result = new List<string>();

            if (!File.Exists(filepath))
            {
                Console.WriteLine("Файл не найден!");
                return result;
            }

            Console.Write("Введите слово для поиска: ");
            string word = Console.ReadLine();

            string[] array = File.ReadAllLines(filepath);


            foreach (string i in array)
            {
                if(i.ToLower().IndexOf(word.ToLower()) >= 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
