namespace TicketBooth
{
    public interface ITicket
    {
        void ShowInfo();
        String GetEventName();
        Decimal GetPrice();
    }
}
