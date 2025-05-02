namespace Task_24_06
{
    internal class Program
    {
        //добавить препятствия не из мира животных, которые будут затормаживать его перемещение
        static void Main(string[] args)
        {
            Kolobok kolobok = new Kolobok();
            List<Animal> animals = new List<Animal>
            {
                new Hare(),
                new Wolf(),
                new Bear(),
                new Fox()
            };
            List<Obstacle> obstacles = new List<Obstacle>
            {
                new Stone(),
                new Pit(),
                new Swamp()
            };
            foreach (var animal in animals)
            {
                foreach (var obst in obstacles)
                {
                    if (!kolobok.IsAlive)
                    break;
                    kolobok.Roll();
                    kolobok.MeetAnimal(animal);
                    kolobok.MeetObstacle(obst);
                }
            }
            if (kolobok.IsAlive)
            {
                Console.WriteLine("Колобок сбежал и стал Senior .NET-разработчиком!");
            }
            else
            {
                Console.WriteLine("Game Over. Колобок не выжил в этом жестоком ООП-мире.");
            }
        }
    }
}
