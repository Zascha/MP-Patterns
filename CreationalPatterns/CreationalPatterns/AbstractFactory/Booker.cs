using CreationalPatterns.AbstractFactory.Interfaces;

namespace CreationalPatterns.AbstractFactory
{
    public static class Booker<TOffice> where TOffice : IOffice, new()
    {
        private static IBookingFactory<TOffice> _factory = new BookingFactory<TOffice>();

        public static IBookRoom BookRoom(string name, int duration)
        {
            return _factory.BookRoom(name, duration);
        }

        public static IBookConference BookConference(string name, int duration)
        {
            return _factory.BookConference(name, duration);
        }
    }
}
