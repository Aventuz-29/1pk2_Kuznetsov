using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01
{
    class Journal
    {
        public int dato; // поле класса - хранит дату издания журнала
        public string emne; // поле класса - хранит тематику журнала
        public string name; // поле класса - хранит название журнала
        public int side; // поле класса - хранит количество страниц журнала
        public int price; // поле класса - хранит цену журнала
        bool isReading = false; // поле класса - хранит статус журнала (куплина ли она или нет)

        //метод класса - печатает в консоль содержание журнала
        public void GetInfo()
        {
            Console.WriteLine($"Журнал тематики: {emne} \nНазвание: {name} \nКолличество страниц: {side} \nДата издания(xxxx): {dato} \nЦена: {price}");
        }
        //метод класса - продает журнал читателю и ставит отметку о продаже
        public void GetBuy()
        {
            if (isReading)
                Console.WriteLine($"Журнал {name}, уже куплин!");
            else
            {
                Console.WriteLine($"Журнал {name}, приобретён.");
                isReading = true;
            }
        }
    }
}
