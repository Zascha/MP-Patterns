using System.Collections.Generic;

namespace CreationalPatterns.AbstractFactory.Interfaces
{
    public interface IOffice
    {
        List<string> RoomNames { get; }
        List<string> ConferenceRooms { get; }
    }
}
