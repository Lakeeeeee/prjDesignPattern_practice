namespace TicketBooth
{
    public abstract class AbstractTicket : ITicket
    {
        public String EventName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Decimal Price { get; set; }

        protected AbstractTicket(string eventName, DateTime purchaseDate, Decimal price)
        {
            EventName = eventName;
            PurchaseDate = purchaseDate;
            Price = price;
        }
        abstract public void ShowInfo();
        abstract public String GetEventName();
        abstract public Decimal GetPrice();
    }
}
