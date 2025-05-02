using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_24_06
{
    public abstract class Obstacle
    {
        public string Name { get; } // Название препятствия

        protected Obstacle(string name)
        {
            Name = name;
        }
        public abstract bool Crashed(Kolobok kolobok);
    }

    public class Stone : Obstacle
    {
        public Stone() : base("Камень") { }
        public override bool Crashed(Kolobok kolobok)
        {
            return false;
        }
    }

    public class Pit : Obstacle
    {
        public Pit() : base("Яма") { }
        public override bool Crashed(Kolobok kolobok)
        {
            return true;
        }
    }

    public class Swamp : Obstacle
    {
        public Swamp() : base("Болото") { }
        public override bool Crashed(Kolobok kolobok)
        {
            return false;
        }
    }
}
