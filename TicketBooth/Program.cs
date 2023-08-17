using Serilog;
using TicketBooth;

// 設定 Logger
Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
Log.Information("|seatArea|purchaseDate|price");

//同時100人查票，查不同區域，同為今天
int numberOfPeople = 100;
TicketFactory ticketFactory = new TicketFactory();
Random rnd = new Random();

Parallel.For(1, numberOfPeople + 1, i =>
{
    int area = rnd.Next(1, 4);
    ticketFactory.Search(i, DateTime.Now, (SeatArea)area);
});



Console.ReadLine();
