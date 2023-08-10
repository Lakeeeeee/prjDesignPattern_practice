using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlyWeight.Tests
{
    [TestClass()]
    public class TicketFactoryTests
    {
        [TestMethod()]
        public void GetTicketTest()
        {
            TicketFactory factory = new TicketFactory();
            DateTime testDate = DateTime.Now;
            SeatArea testSeatArea = (SeatArea)1;
            var ticket = factory.GetTicket(factory.GetKey(testDate, testSeatArea), testDate, testSeatArea);

            Assert.AreEqual(ticket.Result.price, 3115);
        }

        [TestMethod()]
        public void FactoryTest()
        {
            TicketFactory factory = new TicketFactory();
            DateTime testDate = DateTime.Now;
            SeatArea testSeatArea = (SeatArea)1;
            var ticket = factory.GetTicket(factory.GetKey(testDate, testSeatArea), testDate, testSeatArea);



            Assert.AreEqual(ticket.Result.price, 3115);
        }
    }
}