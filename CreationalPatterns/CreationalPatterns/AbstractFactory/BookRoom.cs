using System.Linq;
using CreationalPatterns.AbstractFactory.Interfaces;

namespace CreationalPatterns.AbstractFactory
{
    internal class BookRoom<T> : IBookRoom where T : IOffice, new()
    {
        public string Name { get; set; }
        public int Duration { get; set; }

        public BookRoom(string roonName, int duration)
        {
            var office = new T();
            Name = office.RoomNames.FirstOrDefault(x => x == roonName);
            Duration = duration;
        }
    }
}
