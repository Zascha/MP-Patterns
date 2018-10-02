using System.Collections.Generic;
using System.Linq;
using BehavioralPatterns.Iterator;
using Xunit;

namespace BehavioralPatterns.Tests
{
    public class IteratorTests
    {
        private readonly List<User> _userList;
        private readonly Users _iteratedUserList;

        public IteratorTests()
        {
            _userList = TestData.UsersList;
           _iteratedUserList = new Users { UserList = TestData.UsersList };
        }

        [Fact]
        public void Iterator_UserList_GetCurrent_ReturnsCurrentElement()
        {
            var expectedResult = _userList.First();

            _iteratedUserList.MoveNext();
            var actualResult = _iteratedUserList.Current;

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Iterator_UserList_MoveNext_ReturnsTheNextElementInSequence()
        {
            foreach (var user in _userList)
            {
                _iteratedUserList.MoveNext();

                Assert.Equal(user, _iteratedUserList.Current);
            }
        }

        [Fact]
        public void Iterator_UserList_Reset_SetsCurrentItemIndexToZero()
        {
            var repeatIndex = _userList.Count - 1;

            while (repeatIndex-- > 0)
            {
                _iteratedUserList.MoveNext();
            }

            var preResetResult = _iteratedUserList.Current;

            _iteratedUserList.Reset();
            var postResetResult = _iteratedUserList.Current;

            Assert.NotEqual(preResetResult?.Name, postResetResult?.Name);
            Assert.Equal(postResetResult?.Name, _iteratedUserList.UserList.First().Name);
        }

        [Fact]
        public void Iterator_IEnumerator_EnablesEnumeration()
        {
            foreach (var user in _iteratedUserList)
            {
                Assert.NotNull(user);
            }
        }
    }
}
