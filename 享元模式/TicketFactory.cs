namespace FlyWeight
{
    public class TicketFactory
    {
        private readonly IDictionary<string, Ticket> tickets = new Dictionary<string, Ticket>();
        private readonly object lockObject = new();
        public Ticket Search(int id, string key, DateTime dateTime, SeatArea seatArea)
        {
            lock (lockObject)
            {
                if (!tickets.Keys.Contains(key))
                {
                    tickets.Add(key, seatArea.GetTicket(dateTime));
                }
            }
            tickets[key].ShowInfo(id);

            return tickets[key];
        }

        public string GetKey(DateTime dateTime, SeatArea seatArea)
        {
            return dateTime.Date.ToString() + seatArea.ToString();
        }
    }
}
