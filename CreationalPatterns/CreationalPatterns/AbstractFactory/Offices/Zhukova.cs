using System.Collections.Generic;
using CreationalPatterns.AbstractFactory.Interfaces;

namespace CreationalPatterns.AbstractFactory.Offices
{
    internal class Zhukova: IOffice
    {
        public List<string> RoomNames => new List<string> { "RoomA", "RoomB" };

        public List<string> ConferenceRooms => new List<string> { "ConferenceRoomA", "ConferenceRoomB" };
    }
}
