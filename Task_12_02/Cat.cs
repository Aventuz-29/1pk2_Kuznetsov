using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02
{
    internal class Cat
    {
        public double age; //возраст
        public string breed; //порода
        public string name; //имя

        //информация о коте/кошке
        public void Info()
        {
            Console.WriteLine($"Кошка/Кот {name}, возрост(лет) {age}, порода {breed}.");
        }
        //кормление кота/кошки
        public void feed()
        {
            Console.WriteLine($"Кошка/Кот {name} накормлен(а).");
        }
        //Погладить кота/кошку
        public void pet()
        {
            Console.WriteLine($"Кошка/Кот {name} поглажен(а).");
        }
    }
}
