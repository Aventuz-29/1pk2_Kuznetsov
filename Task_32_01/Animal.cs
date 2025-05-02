using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_24_06
{
    public abstract class Animal
    {
        public string Name { get; } //название животного
                                    //конструктор, который будет срабатывать в дочерних классах
                                    //т.к. используется protected
        protected Animal(string name)
        {
            Name = name;
        }
        public abstract bool CanEat(Kolobok kolobok);
    }

    public class Hare : Animal
    {
        public Hare() : base("Заяц") { }
        public override bool CanEat(Kolobok kolobok)
        {
            return false; // Заяц не смог съесть Колобка
        }
    }

    public class Wolf : Animal
    {
        public Wolf() : base("Волк") { }
        public override bool CanEat(Kolobok kolobok)
        {
            return false; // Волк тоже не справился
        }
    }

    public class Bear : Animal
    {
        public Bear() : base("Медведь") { }
        public override bool CanEat(Kolobok kolobok)
        {
            return false; // Медведь оказался слишком медленным
        }
    }

    public class Fox : Animal
    {
        public Fox() : base("Лиса") { }
        public override bool CanEat(Kolobok kolobok)
        {
            return true; // Лиса хитрая и съела Колобка
        }
    }

}
