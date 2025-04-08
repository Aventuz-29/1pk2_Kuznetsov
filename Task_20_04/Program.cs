using System.Diagnostics;

namespace Task_20_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
            Car
            Bike
            Bus
            Truck
            Motorcycle
            Храните список транспортных средств(можно просто List<VehicleType>).
            Добавьте метод для подсчёта транспорта определённого типа(например, сколько грузовиков). 
            Реализуйте поиск по типу и вывод информации.*/

            Counting counting = new Counting();
            counting.СountingTransport(VehicleType.Bus);
        }
    }
}
