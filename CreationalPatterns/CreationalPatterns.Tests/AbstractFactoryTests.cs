using CreationalPatterns.AbstractFactory;
using CreationalPatterns.AbstractFactory.Interfaces;
using CreationalPatterns.AbstractFactory.Offices;
using Xunit;

namespace CreationalPatterns.Tests
{
    public class AbstractFactoryTests
    {
        private readonly string _roomName;
        private readonly string _conferenceRoomName;
        private readonly int _duration;

        public AbstractFactoryTests()
        {
            _roomName = "RoomA";
            _conferenceRoomName = "ConferenceRoomA";
            _duration = 10;
        }

        [Fact]
        public void Booker_BookRoom_K3V_ReturnsIBookRoomInstance()
        {
            var room = Booker<K3V>.BookRoom(_roomName, _duration);

            Assert.NotNull(room);
            Assert.IsAssignableFrom<IBookRoom>(room);
            Assert.Equal(_roomName, room.Name);
            Assert.Equal(_duration, room.Duration);
        }

        [Fact]
        public void Booker_BookConference_K3V_ReturnsIBookConferenceInstance()
        {
            var room = Booker<K3V>.BookConference(_conferenceRoomName, _duration);

            Assert.NotNull(room);
            Assert.IsAssignableFrom<IBookConference>(room);
            Assert.Equal(_conferenceRoomName, room.Name);
            Assert.Equal(_duration, room.Duration);
        }

        [Fact]
        public void Booker_BookRoom_Zhukova_ReturnsIBookRoomInstance()
        {
            var room = Booker<Zhukova>.BookRoom(_roomName, _duration);

            Assert.NotNull(room);
            Assert.IsAssignableFrom<IBookRoom>(room);
            Assert.Equal(_roomName, room.Name);
            Assert.Equal(_duration, room.Duration);
        }

        [Fact]
        public void Booker_BookConference_Zhukova_ReturnsIBookConferenceInstance()
        {
            var room = Booker<Zhukova>.BookConference(_conferenceRoomName, _duration);

            Assert.NotNull(room);
            Assert.IsAssignableFrom<IBookConference>(room);
            Assert.Equal(_conferenceRoomName, room.Name);
            Assert.Equal(_duration, room.Duration);
        }
    }
}
