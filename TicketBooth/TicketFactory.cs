namespace TicketBooth
{
    public class TicketFactory
    {
        private static readonly object LogLock = new object();
        private readonly IDictionary<string, ConcertTicket> tickets = new Dictionary<string, ConcertTicket>();
        public void Search(int id, DateTime dateTime, SeatArea seatArea)
        {
            tickets[GetTicket(dateTime, seatArea).Key].ShowInfo(id);
        }

        public ConcertTicket GetTicket(DateTime dateTime, SeatArea seatArea)
        {
            string key = dateTime.Date.ToString() + seatArea.ToString();

            lock (LogLock)
            {

                if (!tickets.Keys.Contains(key))
                {
                    tickets.Add(key, new Ticket(seatArea, dateTime.Date));
                }
                return tickets[key];
            }

        }
    }
}
