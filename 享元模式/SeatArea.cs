namespace FlyWeight
{
    public enum SeatArea
    {
        A = 1,
        B = 2,
        C = 3
    }

    public static class SeatAreaExtensions
    {
        public static int GetSeatPrice(this SeatArea seat)
        {
            switch (seat)
            {
                case SeatArea.A:
                    return 3000;
                case SeatArea.B:
                    return 2300;
                case SeatArea.C:
                    return 1600;
                default:
                    throw new ArgumentException(nameof(seat));
            }
        }
    }
}