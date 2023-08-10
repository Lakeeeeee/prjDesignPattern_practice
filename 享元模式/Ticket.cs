using Serilog;

namespace FlyWeight
{
    public class Ticket
    {
        private static readonly object LogLock = new object();

        public readonly string Key;
        protected readonly DateTime PurchaseDate;
        protected readonly SeatArea SeatArea;
        protected int Price { get; set; }

        public Ticket(SeatArea seatArea, DateTime purchaseDate)
        {
            this.SeatArea = seatArea;
            this.PurchaseDate = purchaseDate;
            this.Key = this.PurchaseDate.Date.ToString() + this.SeatArea.ToString();
            this.Price = GetPrice();
        }

        public int GetPrice()
        {
            var remainingDays = (new DateTime(2023, 10, 10, 0, 0, 0, DateTimeKind.Utc) - PurchaseDate).Days;
            return SeatArea.GetSeatPrice() + (int)(((double)365 / remainingDays) * 20);
        }

        public void ShowInfo(int threadId)
        {
            lock (LogLock)
            {
                Log.Information("{threadId}|{seatArea}|{purchaseDate}|{price}", threadId, SeatArea, PurchaseDate.ToLongDateString(), Price.ToString());
            }
        }
    }
}
