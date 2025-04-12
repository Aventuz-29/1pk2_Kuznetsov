using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task_24_06
{
    class NumberRows
    {
        /// <summary>
        /// Метод для нахождения количества строк в текстовом файле
        /// </summary>
        /// <param name="filepath">имя текстового файла</param>
        /// <returns>количество строк</returns>
        public int Numberrows(string filepath)
        {
            int num = 0;

            if (File.Exists(filepath))
            {
                using (StreamReader writer = new StreamReader(filepath))
                {
                    while (writer.ReadLine() != null)
                    {
                        num++;
                    }
                }
                return num;
            }
            else
                Console.WriteLine("Файла не существует!");
            return num;
        }
    }
}
