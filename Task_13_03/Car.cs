using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_03
{
    class Car
    {
        #region поля
        private string num; //закрытое поле номера
        private string stamp; //закрытое поле марки
        private string colour; //закрытое поле цвета
        private int speed; //закрытое поле скорости
        private int maxspeed; //закртыое поле максимальной скорости
        #endregion
        #region свойства
        public string Num
        {
            get { return num; } //аксессор для чтения значения поля
            set                 //аксессор для записи значения в поле
            {
                if (value != null) //если приходящее значение не null
                    num = value; //то в поле записывается приходящее значение
                else
                    Console.WriteLine("Заполните поле!"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }
        }
        public string Stamp
        {
            get { return stamp; } //аксессор для чтения значения поля
            set                 //аксессор для записи значения в поле
            {
                if (value != null) //если приходящее значение не null
                    stamp = value; //то в поле записывается приходящее значение
                else
                    Console.WriteLine("Заполните поле!"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }
        }
        public string Colour
        {
            get { return colour; } //аксессор для чтения значения поля
            set                 //аксессор для записи значения в поле
            {
                if (value != null) //если приходящее значение не null
                    colour = value; //то в поле записывается приходящее значение
                else
                    Console.WriteLine("Заполните поле!"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }
        }
        public int Speed
        {
            get { return speed; } //аксессор для чтения значения поля
            set                 //аксессор для записи значения в поле
            {
                if (value != null) //если приходящее значение не null
                    speed = value; //то в поле записывается приходящее значение
                else
                    Console.WriteLine("Заполните поле корректными данными!"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }
        }
        public int Maxspeed
        {
            get { return maxspeed; } //аксессор для чтения значения поля
            set                 //аксессор для записи значения в поле
            {
                if (value != null && value > 0) //если приходящее значение не null
                    maxspeed = value; //то в поле записывается приходящее значение
                else
                    Console.WriteLine("Заполните поле корректными данными!"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }
        }
        #endregion
        #region методы
        /// <summary>
        /// метод для вывода информации об автомобиле
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine($"Номер авто: {num}, Марка: {stamp}, Цвет: {colour}, Текущая скорость: {speed} км/ч.");
        }
        /// <summary>
        /// метод для езды (равномерное ускорение до превышения скорости)
        /// </summary>
        /// <param name="acceleration">шаг ускорения</param>
        public void Drive(int acceleration)
        {
            if (acceleration <= 0)
            {
                Console.WriteLine("Ускорение должно быть положительным числом.");
                return;
            }

            Console.WriteLine($"Автомобиль {stamp} начинает ускоряться на {acceleration} км/ч за шаг...");

            while (speed + acceleration <= maxspeed)
            {
                speed += acceleration;
                Console.WriteLine($"Текущая скорость: {speed} км/ч.");
            }

            // Если после ускорения скорость превышена
            if (speed + acceleration > maxspeed)
            {
                speed += acceleration;
                Console.WriteLine($"Текущая скорость: {speed} км/ч.");
                Console.Write($"Автомобиль {stamp} превысил допустимую скорость {maxspeed} км/ч. ");
                Brake(); // Автоматическое торможение
            }
        }
        /// <summary>
        /// метод для торможения
        /// </summary>
        public void Brake()
        {
            Console.WriteLine("Торможение...");
            speed = 0;
            Console.WriteLine("Автомобиль остановился.");
        }
        #endregion
        #region конструкторы
        /// <summary>
        /// полный конструктор, с помощью которого заполняются данными все поля
        /// </summary>
        /// <param name="num">номер</param>
        /// <param name="stamp">марка</param>
        /// <param name="colour">цвет</param>
        /// <param name="maxspeed">максимально допустимая скорость</param>
        public Car(string num, string stamp, string colour, int maxspeed)
        {
            Num = num;
            Stamp = stamp;
            Colour = colour;
            Speed = 0;
            Maxspeed = maxspeed;
        }
        /// <summary>
        /// конструктор без поля о цвете
        /// </summary>
        /// <param name="num">номер</param>
        /// <param name="stamp">марка</param>
        /// <param name="maxspeed">максимально допустимая скорость</param>
        public Car(string num, string stamp, int maxspeed)
        {
            Num = num;
            Stamp = stamp;
            Speed = 0;
            Maxspeed = maxspeed;
        }
        /// <summary>
        /// конструктор без поля о максимально допустимой скорости
        /// </summary>
        /// <param name="num">номер</param>
        /// <param name="stamp">марка</param>
        /// <param name="colour">цвет</param>
        public Car(string num, string stamp, string colour)
        {
            Num = num;
            Stamp = stamp;
            Colour = colour;
            Speed = 0;
        }
        /// <summary>
        /// конструтор по умолчанию, который становиться недоступным как только прописываются
        /// остальные конструкторы и его необходимо явно прописать
        /// </summary>
        public Car() { }
        #endregion
    }
}
