using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01
{
    class Newspaper
    {
        public int dato; // поле класса - хранит дату издание газеты
        public string name; // поле класса - хранит название газеты
        public string heading; // поле класса - хранит заголовок газеты
        public int side; // поле класса хранит - количество страниц газеты
        public int price; // поле класса - хранит данные о цене газеты
        bool isReading = false; // поле класса - хранит статус газеты (куплина ли она или нет)

        //метод класса - печатает в консоль информацию о газеты
        public void GetInfo()
        {
            Console.WriteLine($"Заголовок главной полосы: {heading} \nНазвание: {name} \nКолличество страниц: {side} \nДата издания(xxxx): {dato} \nЦена: {price}");
        }
        //метод класса - продает газету читателю и ставит отметку о продаже
        public void GetBuy()
        {
            if (isReading)
                Console.WriteLine($"Газета {name}, уже куплина!");
            else
            {
                Console.WriteLine($"Газета {name}, приобретена.");
                isReading = true;
            }
        }
        //метод класса - заменяет старую газету читателя на новую
        public void Replacement()
        {
            if (isReading)
                Console.WriteLine($"Газета {name}, заменена на новую.");
            else
                Console.WriteLine("Чтобы поменять газету на новую, нужно иметь старую!");
        }
    }
}
