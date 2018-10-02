using System.Linq;
using CreationalPatterns.AbstractFactory.Interfaces;

namespace CreationalPatterns.AbstractFactory
{
    internal class BookConference<T> : IBookConference where T: IOffice, new ()
    {
        public string Name { get; set; }
        public int Duration { get; set; }

        public BookConference(string roonName, int duration)
        {
            var office = new T();
            Name = office.ConferenceRooms.FirstOrDefault(x => x == roonName);
            Duration = duration;
        }
    }
}
