using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_04
{
    class User
    {
        // статическое свойство, представляющее текущего пользователя
        public static User CurrentUser { get; set; }

        /// <summary>
        /// метод для установки текущего пользователя
        /// </summary>
        /// <param name="user">данные о пользователе</param>
        public static void SetCurrentUser(User user)
        {
            CurrentUser = user;
        }

        // cвойства пользователя
        public string Name { get; set; }
        public int Id { get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="id">айди</param>
        public User(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
