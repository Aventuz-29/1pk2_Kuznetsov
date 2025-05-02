using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_24_06
{
    public class Kolobok
    {
        public int Position { get; private set; }
        public int Speed { get; }
        public bool IsAlive { get; private set; }
        public Kolobok()
        {
            Position = 0;
            Speed = 1;
            IsAlive = true;
        }
        public void Roll()
        {
            Position += Speed;
            Console.WriteLine($"Колобок катится, текущая позиция: {Position}");
        }
        //встреча с животным
        public void MeetAnimal(Animal animal)
        {
            if (animal.CanEat(this))
            {
                IsAlive = false;
                Console.WriteLine($"Колобок был съеден {animal.Name}!");
            }
            else
            {
                Console.WriteLine($"Колобок убежал от {animal.Name}!");
            }
        }
        public void MeetObstacle(Obstacle obstacle)
        {
            if (obstacle.Crashed(this) && IsAlive)
            {
                Position--;
                Console.WriteLine($"Колобок задержался из за {obstacle.Name}!");
            }
            else if(!obstacle.Crashed(this) && IsAlive)
            {
                Console.WriteLine($"Колобок обошел {obstacle.Name}!");
            }
        }
    }
}
