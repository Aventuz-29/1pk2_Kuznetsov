using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_06
{
    class DeletingRepeat
    {
        HashSet<char> result = new HashSet<char>();
        List<char> result1 = new List<char>();
        List<char> element = new List<char>
        {
            'd',
            'd',
            'f',
            't',
            'h',
            'f',
        };
        /// <summary>
        /// Метод удаляет повторяющиеся элементы в списке, сохраняя порядок
        /// </summary>
        public void DeletRepeat()
        {
            foreach (char i in element)
            {
                if (result.Add(i))
                {
                    result1.Add(i);
                }
            }
            foreach (char i in result1)
            {
                Console.Write(i + " ");
            }
        }
    }
}
