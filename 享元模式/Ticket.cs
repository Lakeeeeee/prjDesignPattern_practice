using Serilog;

namespace FlyWeight
{
    public abstract class Ticket
    {
        protected string Key
        {
            get
            {
                return this.PurchaseDate.Date.ToString() + this.SeatArea.ToString();
            }
        }
        protected DateTime PurchaseDate { get; set; }
        protected SeatArea SeatArea { get; set; }
        protected int Price { get; set; }

        public int GetPrice()
        {
            var remainingDays = (new DateTime(2023, 10, 10, 0, 0, 0, DateTimeKind.Utc) - PurchaseDate).Days;
            return SeatArea.GetSeatPrice() + (int)(((double)365 / remainingDays) * 20);
        }

        public void ShowInfo(int threadId)
        {
            Log.Information("{threadId}|{seatArea}|{purchaseDate}|{price}", threadId, SeatArea, PurchaseDate.ToUniversalTime().ToLongDateString(), Price.ToString());
        }


    }

    public class ATicket : Ticket
    {
        public ATicket(DateTime dateTime)
        {
            this.PurchaseDate = dateTime;
            this.SeatArea = (SeatArea)1;
            this.Price = this.GetPrice();
        }
    }
    public class BTicket : Ticket
    {
        public BTicket(DateTime dateTime)
        {
            this.PurchaseDate = dateTime;
            this.SeatArea = (SeatArea)2;
            this.Price = this.GetPrice();
        }
    }
    public class CTicket : Ticket
    {
        public CTicket(DateTime dateTime)
        {
            this.PurchaseDate = dateTime;
            this.SeatArea = (SeatArea)3;
            this.Price = this.GetPrice();
        }
    }
}
