using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_06
{
    class Trafficlights
    {
        TrafficLightColor currentColor;
        bool manualControl = false;
        /// <summary>
        /// Метод работы светофора
        /// </summary>
        public void Switching()
        {
            bool bools = true;
            currentColor = TrafficLightColor.Red;

            Console.WriteLine("Автоматический режим. Нажмите любую клавишу для ручного переключения.");

            while (true)
            {
                if (Console.KeyAvailable && bools)
                {
                    Console.ReadKey(true); // Считываем нажатую клавишу
                    manualControl = true;
                    SwitchToNextColor();
                    Console.WriteLine("Ручной режим. Нажмите любую клавишу для следующего цвета. Нажмите 'A' для возврата в автоматический режим.");
                }
                else if (manualControl)
                {
                    // Ожидаем следующего нажатия клавиши в ручном режиме
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.A)
                    {
                        manualControl = false;
                        bools = true;
                        Console.WriteLine("Автоматический режим. Нажмите любую клавишу для ручного переключения.");
                    }
                    else
                    {
                        bools = false;
                        Console.WriteLine(currentColor);
                        SwitchToNextColor();
                    }
                }
                else
                {
                    // Автоматический режим
                    Console.WriteLine(currentColor);
                    Thread.Sleep(3000);
                    SwitchToNextColor();
                }
            }
        }
        /// <summary>
        /// Метод смены цвета
        /// </summary>
        private void SwitchToNextColor()
        {
            switch (currentColor)
            {
                case TrafficLightColor.Red:
                    currentColor = TrafficLightColor.Yellow;
                    break;
                case TrafficLightColor.Yellow:
                    currentColor = TrafficLightColor.Green;
                    break;
                case TrafficLightColor.Green:
                    currentColor = TrafficLightColor.Red;
                    break;
            }
        }
    }
}
