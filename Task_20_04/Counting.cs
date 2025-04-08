using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_04
{
    class Counting
    {
        public VehicleType Transport { get; set; } // свойство

        List<VehicleType> Vehicles = new List<VehicleType> // коллекция транспорта
        {     
            VehicleType.Car,
            VehicleType.Bike,
            VehicleType.Bus,
            VehicleType.Truck,
            VehicleType.Car,
            VehicleType.Motorcycle,
            VehicleType.Truck,
            VehicleType.Bus,
            VehicleType.Car,
            VehicleType.Motorcycle
        };

        /// <summary>
        /// Метод подсчитывает определенный вид транспорта
        /// </summary>
        /// <param name="view">вид транспорта</param>
        public void СountingTransport(VehicleType view)
        {
            int num = 0;
            foreach (VehicleType i in Vehicles)
                if (i == view)
                    num++;
            Console.WriteLine($"Колличество {view}: {num}");
        }
    }
}
