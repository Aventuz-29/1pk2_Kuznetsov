using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_09
{
    class Ticket
    {
        // Автосвойства
        public int Number { get; set; }
        public int Price { get; set; }
        public bool HasLuggage { get; set; }
        public bool IsPrivileged { get; set; }

        // Конструктор
        public Ticket(int number, int price, bool hasLuggage, bool isPrivileged)
        {
            Number = number;
            Price = price;
            HasLuggage = hasLuggage;
            IsPrivileged = isPrivileged;
        }
        public Ticket() { }

        public override string ToString()
        {
            return $"Билет {Number}: Цена {Price} Руб, Багаж: {(HasLuggage ? "Да" : "Нет")}, Льготный: {(IsPrivileged ? "Да" : "Нет")}";
        }

        /// <summary>
        /// Метод для генирации билетов
        /// </summary>
        /// <returns>список билетов</returns>
        public static List<Ticket> GenerateTickets()
        {
            Random random = new Random();
            List<Ticket> tickets = new List<Ticket>();

            for (int i = 1; i <= 30; i++)
            {
                int price = (random.Next(100, 5000));
                bool hasLuggage = random.Next(0, 2) == 1;
                bool isPrivileged = random.Next(0, 5) == 1; 

                tickets.Add(new Ticket(i, price, hasLuggage, isPrivileged));
            }
            return tickets;
        }
        /// <summary>
        /// Метод для нахождения билета с максимальной суммой
        /// </summary>
        /// <param name="tickets">список билетов</param>
        public void MaxSum(List<Ticket> tickets)
        {
            int MaxSum = 0;
            Ticket MaxSum1 = null;
            foreach (Ticket i in tickets)
            {
                if (i.Price > MaxSum)
                {
                    MaxSum = i.Price;
                    MaxSum1 = i;
                }
            }
            Console.WriteLine($"Билет с максимальнной суммой: {MaxSum1}");
        }
        /// <summary>
        /// Метод для нахождения билета с минимальной суммой
        /// </summary>
        /// <param name="tickets">список билетов</param>
        public void MinSum(List<Ticket> tickets)
        {
            int MinSum = 5000;
            Ticket MinSum1 = null;
            foreach (Ticket i in tickets)
            {
                if (i.Price < MinSum)
                {
                    MinSum = i.Price;
                    MinSum1 = i;
                }
            }
            Console.WriteLine($"Билет с минимальнной суммой: {MinSum1}");
        }
        /// <summary>
        /// Метод для нахождения льготных билетов
        /// </summary>
        /// <param name="tickets">список билетов</param>
        public void Luggage(List<Ticket> tickets)
        {
            Console.WriteLine("Билеты с багажом:");
            foreach (var i in tickets)
            {
                if (i.HasLuggage)
                {
                    Console.WriteLine(i);
                }
            }
        }
        /// <summary>
        /// Метод для нахождения билетов с багажом
        /// </summary>
        /// <param name="tickets">список билетов</param>
        public void Preferential(List<Ticket> tickets)
        {
            Console.WriteLine("Льготные билеты:");
            foreach (var i in tickets)
            {
                if (i.IsPrivileged)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
