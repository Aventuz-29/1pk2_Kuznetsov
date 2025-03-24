using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    class Pet
    {
        #region поля
        private string name; //закрытое поле имени
        private string view; //закрытое поле вида
        private double age; //закрытое поле возроста
        private double weight; //закрытое поле веса
        private bool health = true; //закрытое поле здоровья
        #endregion
        #region свойства
        //открытое свойство имени
        public string Name
        {
            get { return name; } //аксессор для чтения значения поля
            set                  //аксессор для записи значения в поле
            {
                if (value != null) //если приходящее значение не null
                    name = value;   //то в поле записывается приходящее значение
                else Console.WriteLine("Заполните поле!"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }
        }
        //открытое свойство вида животного
        public string View
        {
            get { return view; } //аксессор для чтения значения поля
            set                  //аксессор для записи значения в поле
            {
                if (value != null) //если приходящее значение не null
                    view = value;   //то в поле записывается приходящее значение
                else Console.WriteLine("Заполните поле!"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }
        }
        //открытое свойство возроста
        public double Age
        {
            get { return age; }
            set
            {
                if (value > 0) //если текущий возраст больще 0 лет, то значение сохраняется во внутреннее поле
                    age = value;
                else
                    Console.WriteLine("Вы ввели не корректные данные!");
            }
        }
        //открытое свойство веса
        public double Weight
        {
            get { return weight; } //аксессор для чтения значения поля
            set                  //аксессор для записи значения в поле
            {
                if (value != null) //если приходящее значение не null
                    weight = value;   //то в поле записывается приходящее значение
                else Console.WriteLine("Заполние поле!"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }
        }
        //открытое свойство здоровья
        public bool Health
        {
            get { return health; } //аксессор для чтения значения поля
            set                  //аксессор для записи значения в поле
            {
                if (value != null) //если приходящее значение не null
                    health = value;   //то в поле записывается приходящее значение
                else Console.WriteLine("Заполние поле!"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }
        }
        #endregion
        #region методы
        /// <summary>
        /// вывод текущей информации по объекту
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine($"Кличка: {name}");
            Console.WriteLine($"Вид: {view}");
            Console.WriteLine($"Возраст: {age} лет");
            Console.WriteLine($"Вес: {weight} кг");
            Console.WriteLine($"Состояние здоровья: {(health ? "Здоров" : "Нездоров")}");
        }
        /// <summary>
        /// изменение старого веса животного на новый
        /// </summary>
        /// <param name="newWeight">новый вес животного</param>
        public void UpdateWeight(double newWeight)
        {
            if (newWeight >= 0)
            {
                weight = newWeight;
                Console.WriteLine($"Вес обновлен: {weight} кг");
            }
            else
            {
                Console.WriteLine("Ошибка: вес не может быть отрицательным.");
            }
        }
        /// <summary>
        /// изменение статуса здоровья
        /// </summary>
        /// <param name="Healt">новый статус здоровья</param>
        public void UpdateHealthStatus(bool Health)
        {
            health = Health;
            Console.WriteLine($"Состояние здоровья обновлено: {(health ? "Здоров" : "Нездоров")}");
        }
        #endregion
        #region конструкторы
        /// <summary>
        /// полный конструктор, с помощью которого заполняются данными все поля
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="view">вид животного</param>
        /// <param name="age">возраст</param>
        /// <param name="weight">вес</param>
        /// <param name="health">здоровье</param>
        public Pet(string name, string view, int age, double weight, bool health)
        {
            Name = name;
            View = view;
            Age = age;
            Weight = weight;
            Health = health;
        }
        /// <summary>
        /// конструктор без отметки о здоровье (по умолчанию здоров)
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="view">вид животного</param>
        /// <param name="age">возраст</param>
        /// <param name="weight">вес</param>
        public Pet(string name, string view, int age, double weight)
        {
            Name = name;
            View = view;
            Age = age;
            Weight = weight;
        }
        /// <summary>
        ///  конструктор без отметки о здоровье (по умолчанию здоров) и весе
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="view"></param>
        /// <param name="age"></param>
        public Pet(string name, string view, int age)
        {
            Name = name;
            View = view;
            Age = age;
        }
        /// <summary>
        /// конструтор по умолчанию, который становиться недоступным как только прописываются
        /// остальные конструкторы и его необходимо явно прописать
        /// </summary>
        public Pet() { }
        #endregion
    }
}