using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_24_08
{
    class SearchTexts
    {
        /// <summary>
        /// Методдля поиска и замены текста в файле
        /// </summary>
        /// <param name="filepath">имя файла</param>
        public static void searchTexts(string filepath)
        {
            if (!File.Exists(filepath))
            {
                Console.WriteLine("Файл не найден.");
            }

            Console.WriteLine("\nВведите текст для поиска:");
            string searchText = Console.ReadLine();

            Console.WriteLine("\nВведите текст для замены:");
            string replaceText = Console.ReadLine();

            string fileContent = File.ReadAllText(filepath);

            fileContent = fileContent.Replace(searchText, replaceText);

            File.WriteAllText(filepath, fileContent);
        }
    }
}
