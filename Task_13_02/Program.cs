using Task_13_02;

namespace Task_13_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*создать класс питомца
            свойства: кличка, вид животного, возраст, вес, отметка о состонии здоровья(здоров / нездоров)
            методы:
            вывод информации об объекте
            изменение значения веса животного
            изменение отметки о состоянии здоровья
            конструторы:
            предусмотрите разные варианты инициализации объектов*/

            Pet pet = new Pet
            {
                Name = "Тим",
                View = "Собака",
                Age = 2,
                Weight = 2.7
            };
            pet.GetInfo();
            pet.UpdateHealthStatus(false);
            pet.UpdateWeight(3.4);

            Pet pet2 = new Pet("Барсик", "Кот", 3, 4.5, true);
            pet2.GetInfo();
        }
    }
}