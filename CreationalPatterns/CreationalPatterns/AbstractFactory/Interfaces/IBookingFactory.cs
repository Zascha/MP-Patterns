namespace CreationalPatterns.AbstractFactory.Interfaces
{
    public interface IBookingFactory<TOffice> where TOffice : IOffice
    {
        IBookRoom BookRoom(string roomName, int duration);
        IBookConference BookConference(string conference, int duration);
    }
}
