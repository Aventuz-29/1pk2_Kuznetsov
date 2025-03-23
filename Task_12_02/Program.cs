namespace Task_12_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создайте проект с классом Cat и Dog, полностью самостоятельно продумайте данные для объектов класса и их функционал
            Cat cat1 = new Cat();
            Dog dog1 = new Dog();

            cat1.name = "Шарик";
            cat1.age = 2;
            cat1.breed = "Шотландская";

            cat1.feed();

            dog1.name = "Шарик";
            dog1.age = 2;
            dog1.breed = "Даберман";

            dog1.feed();
        }
    }
}