using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task_20_05
{
    class Check
    {
        //AccessLevel level = AccessLevel.Guest;
        public AccessLevel accessLevel { get; set; } // свойство

        /// <summary>
        /// Метод авторизации пользователя
        /// </summary>
        /// <param name="level">уровень доступа</param>
        public AccessLevel Authorization(AccessLevel level)
        {
            accessLevel = level;
            return level;
        }
        /// <summary>
        /// Метод для действий пользователя
        /// </summary>
        public void Action()
        {
            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1. Чтение");
            Console.WriteLine("2. Комментирование");
            Console.WriteLine("3. Удаление поста");
            Console.WriteLine("4. Изменение настроек системы");

            Console.Write("Выберите действие (1-4): ");
            int num1 = int.Parse(Console.ReadLine());
            num1--;
            if (num1 <= (int)accessLevel)
                Console.WriteLine("Действие выполнено!");
            else 
                Console.WriteLine("У вас нет прав доступа к действию!");

        }
    }
}
