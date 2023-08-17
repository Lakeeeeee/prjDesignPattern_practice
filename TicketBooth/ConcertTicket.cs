using Serilog;

namespace TicketBooth
{
    public class ConcertTicket : AbstractTicket
    {
        public ConcertTicket(String eventName, DateTime purchaseDate, Decimal price) : base(eventName, purchaseDate, price)
        {
            this.Key = this.EventName + this.PurchaseDate;
            this.LastPurchaseDate = new DateTime(2023, 12, 20, 19, 00, 00, DateTimeKind.Utc);
        }
        public readonly string Key;
        public readonly DateTime LastPurchaseDate;
        public SeatArea SeatArea { get; set; }

        public override String GetEventName()
        {
            return this.EventName;
        }
        public override void ShowInfo()
        {
            Log.Information("{threadId}|{seatArea}|{purchaseDate}|{price}", Key, SeatArea, PurchaseDate.ToLongDateString(), Price.ToString());
        }

        public override Decimal GetPrice()
        {
            return this.Price;
        }
    }
}
