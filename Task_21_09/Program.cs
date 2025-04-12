using System.Net.Sockets;

namespace Task_21_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*создайте класс билета(Ticket).сгенерируйте список из 30 билетов.произведите:
            поиск билета с максимальной суммой,
            билета с минимальной суммой,
            выведите список билетов с багажом
            выведите список люготных билетов*/

            List<Ticket> tickets = Ticket.GenerateTickets();

            Ticket ticket = new Ticket();
            ticket.MaxSum(tickets);
            ticket.MinSum(tickets);
            ticket.Luggage(tickets);
            ticket.Preferential(tickets);
        }
    }
}
