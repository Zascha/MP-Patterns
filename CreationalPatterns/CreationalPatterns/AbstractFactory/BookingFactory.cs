using CreationalPatterns.AbstractFactory.Interfaces;

namespace CreationalPatterns.AbstractFactory
{
    internal class BookingFactory<TOffice> : IBookingFactory<TOffice> where TOffice : IOffice, new()
    {
        public IBookRoom BookRoom(string roomName, int duration)
        {
            return new BookRoom<TOffice>(roomName, duration);
        }

        public IBookConference BookConference(string conference, int duration)
        {
            return new BookConference<TOffice>(conference, duration);
        }
    }
}
