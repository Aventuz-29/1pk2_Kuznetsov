﻿using Task_13_02;
using Task_13_03;

namespace Task_13_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*создайте класс автомобиля
            свойства:
            номер авто, марка, цвет, текущая скорость
            методы:
            езда(симитировать равномерное ускорение скорости автомобиля)
            торможение(при превышении скорости автомобиля свыше допустимой - он должен остановиться)
            конструторы
            предусмотрите разные варианты инициализации объектов*/
            
            Car car = new Car("A123BC", "Toyota", "Red", 100);

            car.GetInfo();
            car.Drive(30);
        }
    }
}