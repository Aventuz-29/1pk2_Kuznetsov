using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02
{
    class Dog
    {
        public double age; //возраст 
        public string breed; // порода
        public string name; // имя

        //Информация о собаке
        public void Info()
        {
            Console.WriteLine($"Собака {name}, возрост(лет) {age}, порода {breed}.");
        }
        //Кормление собаки
        public void feed()
        {
            Console.WriteLine($"Собака {name} накормлена.");
        }
        //Игра с собакой(бросание палки)
        public void stick()
        {
            Console.WriteLine($"Вы бросили палку... Собака {name} принесла палку.");
        }        
    }
}
