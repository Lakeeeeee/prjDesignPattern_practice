namespace Prototype
{
    public class Ticket : ICloneable
    {

        private String EventName;
        private DateTime EventDate;
        private Location Location;
        private Int32 Price;
        public void SetEventName(String eventName)
        {
            this.EventName = eventName;
        }

        public void SetEventDate(DateTime eventDate)
        {
            this.EventDate = eventDate;
        }

        public void SetLocation(Location location)
        {
            this.Location = location;
        }
        public void SetPrice(Int32 price)
        {
            this.Price = price;
        }

        public void Infor()
        {
            Console.WriteLine("活動名稱:" + this.EventName);
            Console.WriteLine("活動日期:" + this.EventDate);
            Console.WriteLine("座位區:" + this.Location);
            Console.WriteLine("票價:" + this.Price);
        }

        public object Clone()
        {
            return new Ticket()
            {
                EventName = this.EventName,
                EventDate = this.EventDate,
                Location = this.Location,
                Price = this.Price,
            };
        }
    }
}
