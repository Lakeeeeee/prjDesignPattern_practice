﻿namespace FlyWeight
{
    public class TicketFactory
    {
        private readonly IDictionary<string, Ticket> tickets = new Dictionary<string, Ticket>();
        public void Search(int id, DateTime dateTime, SeatArea seatArea)
        {
            tickets[GetTicket(dateTime, seatArea).Key].ShowInfo(id);
        }

        public Ticket GetTicket(DateTime dateTime, SeatArea seatArea)
        {
            string key = dateTime.Date.ToString() + seatArea.ToString();

            if (!tickets.Keys.Contains(key))
            {
                tickets.Add(key, new Ticket(seatArea, dateTime.Date));
            }

            return tickets[key];
        }
    }
}
